using UnityEngine;
using System.Collections;

public class FoodController : MonoBehaviour {

	public float timeToEat; 
	[HideInInspector] public bool eaten;

	private float timeEating;
	private AudioSource nomnom;

	void OnEnable () {
		nomnom = GetComponent<AudioSource> ();
		timeToEat = Mathf.Floor (Random.Range (1.0f, 5.0f));
		gameObject.transform.localScale = new Vector3 (timeToEat, timeToEat);
		eaten = false;
	}

	void OnCollisionStay2D (Collision2D collision){
		if (collision.gameObject.tag == "Player"){
			nomnom.pitch += Time.deltaTime/2.0f;
			if (!nomnom.isPlaying) {
				nomnom.Play ();
			}
			timeEating += Time.deltaTime;
			if (gameObject.transform.localScale.x>=0.1f && gameObject.transform.localScale.y>=0.1f){
				gameObject.transform.localScale -= new Vector3 (Time.deltaTime, Time.deltaTime);
			}
			if (timeEating >= timeToEat) {
				eaten = true;
				nomnom.pitch = 1.0f;
				GameManagerController.eatFood ();
			}
		}
	}
}
