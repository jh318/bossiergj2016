﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EndGameState : MonoBehaviour {
	public static string EndText;
	//var textscript : TextController;
	public Text text;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (GameObject.Find ("player") == null) {
			//print ("Game Over");
			text.text = "Game Over\nPress \"Enter\" to restart";
			if (Input.GetKeyDown (KeyCode.Return)) {
				Application.LoadLevel (0);
			}
		}

    }
	//void OnGUI(){
	//	GUI.Label(new Rect(10,50,10,20),"Hello World");
	//} 

}