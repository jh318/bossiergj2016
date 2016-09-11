using UnityEngine;
using System.Collections;

public class enemy3ai : MonoBehaviour {
	public int speed;
	private float y;
	private int b = 0;
	public GameObject borderTop;
	// Use this for initialization
	void OnEnable () {
		y = gameObject.transform.position.y;
		speed = 0;
		b = Random.Range(-30, 8);
		Vector3 temp = new Vector3((borderTop.transform.position.x + b), borderTop.transform.position.y, 0);
		gameObject.transform.position += temp;
	}
	
	// Update is called once per frame
	void Update () {
		//float y = gameObject.transform.position.y;
		y += speed;
	}
		void OnCollisionEnter2D(Collision2D collision){
		if (collision.gameObject.tag == "border"){
			gameObject.SetActive(false);
		}
	}
}
