using UnityEngine;
using System.Collections;


public class powerupcollision : MonoBehaviour {
	

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
		
	// this will disable the player gameObject.
	void OnCollisionEnter2D(Collision2D collision){
		if (collision.gameObject.tag == "Player"){
			gameObject.SetActive(false);
		}
	}
}

