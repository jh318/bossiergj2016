using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	
	private RigidBody2D rb;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		float x = Input.GetAxis("Horizontal");
		float y = Input.GetAxis("Vertical");
		
		Vector2 heading = new Vector2(x, y);


			
	}

	void FixedUpdate(){

	}
}
