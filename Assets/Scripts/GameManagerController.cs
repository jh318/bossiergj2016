using UnityEngine;
using System.Collections;

public class GameManagerController : MonoBehaviour {

	private FoodController[] foods;
	private int score;

	void Start () {
		foods = FindObjectsOfType(typeof(FoodController)) as FoodController[];
	}
	
	void Update () {
		foreach (FoodController food in foods) {
			if (food.eaten == true) {
				score += (int)food.timeToEat;
				Debug.Log ("Score! " + score.ToString ());
				food.eaten = false;
			}
		}
	}
}
