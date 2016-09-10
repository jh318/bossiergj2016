using UnityEngine;
using System.Collections;

public class EnemySpawnerController : MonoBehaviour {
	public GameObject enemy; //create variable to hold enemy GameObject
	//public GameObject spawner;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Time.frameCount%360.0f == 0){ //check if total frame count is divisiable by 360 frames IE every 6 seconds, spawn enemy
			Instantiate(enemy); //create instance of object
		}
		if (GetGeneralSpawnCoordinates.inArena == true) {
			Instantiate (enemy);
		}
	
	}
}
