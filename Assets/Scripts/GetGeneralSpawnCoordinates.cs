using UnityEngine;
using System.Collections;

public class GetGeneralSpawnCoordinates : MonoBehaviour {
	public GameObject borderRight; //get arena borders
	public GameObject borderLeft;
	public GameObject borderTop;
	public GameObject borderBottom;
	public static bool inArena = false;


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

		int xSpawn = Random.Range (-21, 21); //randomly generate x position between 2 numbers
		int ySpawn = Random.Range (-21, 21); //randomly generate y position between 2 numbers
		inArena = false;//obj coord is not in arena

		if ((borderTop.transform.position.y > ySpawn && borderBottom.transform.position.y < ySpawn) && (borderLeft.transform.position.x < xSpawn && borderRight.transform.position.x > xSpawn)){
			//check if the generated coord is inside the arena
			inArena = true; //obj coord is not in area
		}

	}
}
