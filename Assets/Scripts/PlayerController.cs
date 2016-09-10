using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour {
	
	private RigidBody2D body;
	private Vector2 heading;
	public float speed = 10;
	public float turnSpeed = 5;

	void Start () {
		body = gameObject.GetComponent<Rigidbody2D>();
	}
	
	void Update () 
	{
		float x = Input.GetAxis("Horizontal");
		float y = Input.GetAxis("Vertical");
		
		Vector2 heading = new Vector2(x, y);

		if (heading.sqrMagnitude < 0.1f)
        {
            return;
        }
        else
        {
            float angle = Mathf.Atan2(y, x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Slerp(
                transform.rotation,
                Quaternion.Euler(0, 0, angle),
                turnspeed * Time.deltaTime);
        }  
	}

	void FixedUpdate(){
        body.MovePosition(body.position + heading.normalized * speed * Time.deltaTime);
	}

	void OnCollisionEnter2D(Collision2D collision){
		if (collision.gameObject.tag == "Enemy"){
			gameObject.SetActive(false);
		}
	}
}
