using UnityEngine;
using System.Collections;
[RequireComponent(typeof(PolygonCollider2D))]
public class EnemyController : MonoBehaviour {

	private Rigidbody2D body;
	private Vector2 heading;
	private PlayerController player;

	public float speed = 100;
	public float turnspeed = 5;

	void OnEnable () {
		body = gameObject.GetComponent<Rigidbody2D>();
		player = GameObject.FindObjectOfType(typeof(PlayerController)) as PlayerController;
	}
	
	void Update () 
	{
		heading = (Vector2)(player.transform.position - transform.position);

        float angle = Mathf.Atan2(heading.y, heading.x) * Mathf.Rad2Deg - 90;
        transform.rotation = Quaternion.Euler(0, 0, angle);
	}

	void FixedUpdate(){
		//this is where the players movement is actually being calculated
        body.velocity = (heading.normalized * speed / Time.fixedDeltaTime);
	}

	//this will disable the player gameObject.
	void OnCollisionEnter2D(Collision2D collision){
		if (collision.gameObject.tag == "KillsEnemy"){
			gameObject.SetActive(false);
		}
	}
}

