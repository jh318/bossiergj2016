using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class FoodSpawnerController : MonoBehaviour {

	public int maxSpawn;
	[HideInInspector] public static int currentSpawn;
	public GameObject foodPrefab;

	private GameObject foodSpawned;
	public GameObject borderRight; //get arena borders
	public GameObject borderLeft;
	public GameObject borderTop;
	public GameObject borderBottom;
	public static bool inArena = false;
	public static int xSpawn = 0;
	public static int ySpawn = 0;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (currentSpawn < maxSpawn) {
			Spawn ();
		}
	}

	void Spawn () {
		foodSpawned = ObjectPooling.Spawn(foodPrefab);
		xSpawn = Random.Range (-21, 21); //randomly generate x position between 2 numbers
		ySpawn = Random.Range (-21, 21); //randomly generate y position between 2 numbers
		inArena = false;//obj coord is not in arena

		if ((borderTop.transform.position.y > ySpawn && borderBottom.transform.position.y < ySpawn) && (borderLeft.transform.position.x < xSpawn && borderRight.transform.position.x > xSpawn)){
			//check if the generated coord is inside the arena
			inArena = true; //obj coord is not in area

			foodSpawned.transform.position = new Vector3 (xSpawn, ySpawn);
		}
		currentSpawn++;
	}
}
