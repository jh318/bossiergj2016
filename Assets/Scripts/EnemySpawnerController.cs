using UnityEngine;
using System.Collections;

public class EnemySpawnerController : MonoBehaviour {
	public GameObject enemy; //create variable to hold enemy GameObject
	//public GameObject spawner;
	//private Vector3 enemyPos = new Vector3(0,0,0);

	// Use this for initialization
	void Start () {
		//Vector3 enemyPos = gameObject.transform.position;
		//enemyPos.x = GetGeneralSpawnCoordinates.xSpawn;
		//enemyPos.y = GetGeneralSpawnCoordinates.ySpawn;
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Time.frameCount%360.0f == 0){ //check if total frame count is divisiable by 360 frames IE every 6 seconds, spawn enemy
			Instantiate(enemy, GetGeneralSpawnCoordinates.enemyPos, Quaternion.identity); //create instance of object
		}
		//if (GetGeneralSpawnCoordinates.inArena == true) {
		//	Instantiate (enemy, enemyPos, Quaternion.identity);
		//}	
	}
}
