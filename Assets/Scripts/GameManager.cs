﻿using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public int score = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void AddToScore(int points){
		score += points;
	}
}
