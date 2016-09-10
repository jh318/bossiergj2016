using UnityEngine;
using System.Collections;

public class GetGeneralSpawnCoordinates : MonoBehaviour {
	public GameObject borderRight; //get arena borders
	public GameObject borderLeft;
	public GameObject borderTop;
	public GameObject borderBottom;
	public static bool inArena = false;
	public static int xSpawn = 0;
	public static int ySpawn = 0;
	public static Vector3 enemyPos = new Vector3(0,0,0);


	// Use this for initialization
	void Start () {
		Vector3 enemyPos = gameObject.transform.position;

	}
	
	// Update is called once per frame
	void Update () {

		xSpawn = Random.Range (-21, 21); //randomly generate x position between 2 numbers
		ySpawn = Random.Range (-21, 21); //randomly generate y position between 2 numbers
		inArena = false;//obj coord is not in arena

		if ((borderTop.transform.position.y > ySpawn && borderBottom.transform.position.y < ySpawn) && (borderLeft.transform.position.x < xSpawn && borderRight.transform.position.x > xSpawn)){
			//check if the generated coord is inside the arena
			inArena = true; //obj coord is not in area

			enemyPos.x = GetGeneralSpawnCoordinates.xSpawn;
			enemyPos.y = GetGeneralSpawnCoordinates.ySpawn;
		}

	}
}
