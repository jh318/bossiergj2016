using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class GameManagerController : MonoBehaviour {

	public static GameManagerController instance;
	public Text scoreText;
	public Text gameOver;
	public Text startText;

<<<<<<< HEAD
	private static FoodController[] foods;
	private static int score;
=======
	public enum State {
		Waiting,
		Playing,
		GameOver
	}

	private NymphSpawner nymphSpawner;
	private static FoodController[] foods;
	public int score;
	private PlayerController player;
	private State gameState = State.Waiting;

	void Awake () {
		instance = this;
		player = Object.FindObjectOfType (typeof(PlayerController)) as PlayerController;
		nymphSpawner = Object.FindObjectOfType (typeof(NymphSpawner)) as NymphSpawner;

		player.gameObject.SetActive (false);
		nymphSpawner.gameObject.SetActive (false);
	}
>>>>>>> 8f54bbafc01e6b7676192254d8bf9c8775668f0c

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
				nymphSpawner.gameObject.SetActive (false);
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
