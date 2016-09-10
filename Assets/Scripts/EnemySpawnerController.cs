using UnityEngine;
using System.Collections;

public class EnemySpawnerController : MonoBehaviour {
	public GameObject enemy;
	public GameObject spawner;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Time.frameCount > 360.0f){
			Instantiate(enemy);
		}
	
	}
}
