﻿using UnityEngine;
using System.Collections;

public class EndGameState : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
		
	
	}
	
	// Update is called once per frame
	void Update () {
		if (GameObject.Find ("player") == null) {
			print ("Game Over");

			if (Input.GetKeyDown (KeyCode.Return)) {
				Application.LoadLevel (0);
			}
		}

    }
	//void OnGUI(){
	//	GUI.Label(new Rect(10,50,10,20),"Hello World");
	//} 

}