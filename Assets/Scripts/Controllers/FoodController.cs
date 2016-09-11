using UnityEngine;
using System.Collections;

public class FoodController : MonoBehaviour {

	public float maxtimeToEat = 5f; 
	public float minTimeToEat = 1f;
	public float minSize = .2f;

	public float timeToEat {
        get {return _timeToEat;}
    }

	private float _timeToEat;
	[HideInInspector] public bool eaten;

	private AudioSource nomnom;

	void OnEnable () {
		nomnom = GetComponent<AudioSource> ();
		_timeToEat = Mathf.Floor (Random.Range (minTimeToEat, maxtimeToEat));
		gameObject.transform.localScale = new Vector3 (_timeToEat, _timeToEat);
		eaten = false;
	}

	void OnTriggerStay2D (Collider2D collider){
		if (collider.gameObject.tag == "Player"){
			nomnom.pitch += Time.deltaTime/2.0f;
			if (!nomnom.isPlaying) {
				nomnom.Play ();
			}

			if (gameObject.transform.localScale.x>= minSize && gameObject.transform.localScale.y>= minSize){
				gameObject.transform.localScale -= new Vector3 (Time.deltaTime, Time.deltaTime);
			}

			if (gameObject.transform.localScale.x <= minSize && gameObject.transform.localScale.y <= minSize) {
				eaten = true;
				nomnom.pitch = 0.0f;
				GameManagerController.eatFood ();
			}
		}
	}
}
