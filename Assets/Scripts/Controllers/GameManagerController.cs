using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class GameManagerController : MonoBehaviour {

	public static GameManagerController instance;
	public Text scoreText;
	public Text gameOver;
	public Text startText;




	public enum State {
		Waiting,
		Playing,
		GameOver
	}

	private NymphSpawner nymphSpawner;
	private FoodSpawner foodSpawner;
	private Enemy1Spawner enemy1Spawner;
	private Enemy2Spawner enemy2Spawner;

	private static FoodController[] foods;
	public int score;
	private PlayerController player;
	private State gameState = State.Waiting;

	void Awake () {
		instance = this;
		player = Object.FindObjectOfType (typeof(PlayerController)) as PlayerController;
		nymphSpawner = Object.FindObjectOfType (typeof(NymphSpawner)) as NymphSpawner;
		foodSpawner = Object.FindObjectOfType (typeof(FoodSpawner)) as FoodSpawner;
		enemy1Spawner = Object.FindObjectOfType (typeof(Enemy1Spawner)) as Enemy1Spawner;
		enemy2Spawner = Object.FindObjectOfType (typeof(Enemy2Spawner)) as Enemy2Spawner;

		player.gameObject.SetActive (false);
		nymphSpawner.gameObject.SetActive (false);
		foodSpawner.gameObject.SetActive (false);
		enemy1Spawner.gameObject.SetActive (false);
		enemy2Spawner.gameObject.SetActive (false);

	}

	void Start () {
		SetScoreText ();
	}
	
	void Update () {
		switch (gameState) {
		case State.Waiting:
			if (Input.anyKeyDown) {
				gameState = State.Playing;
				player.gameObject.SetActive (true);
				player.transform.position = Vector3.zero;
				startText.gameObject.SetActive (false);
				gameOver.gameObject.SetActive (false);
				nymphSpawner.Reset ();
				foodSpawner.Reset ();
				enemy1Spawner.Reset ();
				enemy2Spawner.Reset ();

				scoreText.gameObject.SetActive(true);
				eatFood ();
				score = 0;
				SetScoreText();
			}
			break;

		case State.Playing:
			if (!player.gameObject.activeSelf){
				gameState = State.GameOver;
				player.gameObject.SetActive (false);
				nymphSpawner.DisableAll ();
				foodSpawner.DisableAll ();
				enemy1Spawner.DisableAll ();
				enemy2Spawner.DisableAll ();
				startText.gameObject.SetActive (false);
				gameOver.gameObject.SetActive (true);
				gameOver.text = "Game Over\nPress \"Enter\" to restart";
			}
			break;

		case State.GameOver:
			if (Input.anyKeyDown) {
				gameState = State.Waiting;
				startText.text = "Press Any Key to continue.";
			}
			break;

		default:
			break;

		}
	}

	void SetScoreText() {
		instance.scoreText.text = "Score: " + score;
	}

	public void AddToScore (int points){
		instance.score += points;
		instance.SetScoreText ();
	}

	public static void eatFood (){
		foods = FindObjectsOfType(typeof(FoodController)) as FoodController[];
		foreach (FoodController food in foods) {
			if (food.eaten == true) {
				instance.AddToScore((int)food.timeToEat);
				food.eaten = false;
				food.gameObject.SetActive (false);
			}
		}
	}
}
