using UnityEngine;
using System.Collections;

public class TopSpawn : MonoBehaviour {
	//public GameObject borderRight; //get arena borders
	//public GameObject borderLeft;
	//public GameObject borderTop;
	//public GameObject borderBottom;

	//public GameObject[] borders;
	public GameObject enemy;
	public GameObject borderTop;
	private int b = 0;

	// Use this for initialization
	void Start () {
		//Vector3 enemyPos = gameObject.transform.position;
		//GameObjects[] borders;
		//borders = GameObject.FindGameObjectsWithTag("border"); //populate array with border gameobjects
		//b = Random.Range(0, 3);
		//Instantiate(enemy, new Vector3(borders[b].transform.position.x, borders[b].transform.position.y, 0), Quaternion.identity);

	}

	// Update is called once per frame
	void Update () {
		b = Random.Range(-18, 18);
		if (Time.frameCount%360.0f == 0){ //check if total frame count is divisiable by 360 frames IE every 6 seconds, spawn enemy
			Instantiate(enemy, new Vector3(borderTop.transform.position.x+b, borderTop.transform.position.y, 0), Quaternion.identity); //create instance of object at this position
		}

	}
}
