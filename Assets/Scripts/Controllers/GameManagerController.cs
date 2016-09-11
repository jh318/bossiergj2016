using UnityEngine;
using System.Collections;

public class GameManagerController : MonoBehaviour {

	private static FoodController[] foods;
	private static int score;

	void Start () {
		
	}
	
	void Update () {
		eatFood ();
	}

	public static void eatFood (){
		foods = FindObjectsOfType(typeof(FoodController)) as FoodController[];
		foreach (FoodController food in foods) {
			if (food.eaten == true) {
				score += (int)food.timeToEat;
				Debug.Log ("Score! " + score.ToString ());
				food.eaten = false;
				food.gameObject.SetActive (false);
			}
		}
	}
}
