﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class TextController : MonoBehaviour {
	public Text text;


	// Use this for initialization
	void Start () {
		//text.text = "Game Over: Press \"Enter\" to Restart";
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)){
			text.text = "Space key pressed";
		}
	
	}
}
