using UnityEngine;
using System.Collections;

public class enemy2ai : MonoBehaviour {
	
	private Rigidbody2D body;
	private Vector2 heading;
	private PlayerController player;
	public float coord;
	//private b = Random.Range(0, 3);
	public Vector3 firstPosition;
	public Vector3 secondPosition;

	public float speed = 100;

	public GameObject[] borders;
	//public GameObject enemy;
	//public ArrayList speed;
	private int b = 0;
	// Use this for initialization
	void Start () {
		borders = GameObject.FindGameObjectsWithTag("border"); //populate list with 4 borders
		b = Random.Range(0, 3); //randomly select 1 border
		firstPosition = new Vector3((borders[b].transform.position.x), borders[b].transform.position.y, 0); //pick this random border and move to it
		gameObject.transform.position += firstPosition; //change the game object's position
		secondPosition = new Vector3 (player.transform.position.x, player.transform.position.y, 0); //locate the player
		//Instantiate(enemy, new Vector3(borders[b].transform.position.x, borders[b].transform.position.y, 0), Quaternion.identity);

		body = gameObject.GetComponent<Rigidbody2D>(); //Rotate object? vvvvvvvv
		player = GameObject.FindObjectOfType(typeof(PlayerController)) as PlayerController;
		heading = (Vector2)(player.transform.position - transform.position);
		float angle = Mathf.Atan2(heading.y, heading.x) * Mathf.Rad2Deg - 90;
		transform.rotation = Quaternion.Euler(0, 0, angle);
	}

//	void Start () {
		
	//}
	
	// Update is called once per frame
	void Update () {
		//coord = gameObject.transform.position;
		//while(transform.position < secondPosition){ //while object position does not match player position, move.
			transform.position = new Vector3 (transform.position.x + 1.0f, transform.position.y + 1.0f, 0); //need to figure out how to move in direction of player. out of time.
		//}
	}
}
