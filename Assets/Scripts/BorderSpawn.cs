using UnityEngine;
using System.Collections;

public class BorderSpawn : MonoBehaviour {
	//public GameObject borderRight; //get arena borders
	//public GameObject borderLeft;
	//public GameObject borderTop;
	//public GameObject borderBottom;
	public static bool inArena = false;
	public static int xSpawn = 0;
	public static int ySpawn = 0;
	public static Vector3 enemyPos = new Vector3(0,0,0);
	public GameObject[] borders;
	public GameObject enemy;

	// Use this for initialization
	void Start () {
		//Vector3 enemyPos = gameObject.transform.position;
		//GameObjects[] borders;
		borders = GameObject.FindGameObjectsWithTag("border"); //populate array with border gameobjects
	}
	
	// Update is called once per frame
	void Update () {

		if (Time.frameCount%360.0f == 0){ //check if total frame count is divisiable by 360 frames IE every 6 seconds, spawn enemy
			Instantiate(enemy, borders[Random.Range(0,3)].transform.position, Quaternion.identity); //create instance of object at this position
		}
	
	}
}
