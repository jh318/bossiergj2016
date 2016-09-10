using UnityEngine;
using System.Collections;

public class FoodController : MonoBehaviour {

	public float timeToEat; 

	private float timeEating;
	private Transform selfTr;

	void Start () {
		selfTr = GetComponent<Transform> ();
		selfTr.localScale = new Vector3 (timeToEat, timeToEat);
	}

	void OnCollisionStay2D (Collision2D collision){
		if (collision.gameObject.tag == "Player"){
			Debug.Log (timeEating.ToString ());
			timeEating += Time.deltaTime;
			if (selfTr.localScale.x>=0.0f && selfTr.localScale.y>=0.0f){
				selfTr.localScale -= new Vector3 (Time.deltaTime, Time.deltaTime);
			}
			if (timeEating >= timeToEat) {
				gameObject.SetActive (false);
			}
		}
	}
}
