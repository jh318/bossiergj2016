using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
<<<<<<< HEAD
public class PlayerController : MonoBehaviour {
	
	private RigidBody2D body;
	private Vector2 heading;
	public float speed = 10;
	public float turnSpeed = 5;

	void Start () {
		body = gameObject.GetComponent<Rigidbody2D>();
=======
[RequireComponent(typeof(PolygonCollider2D))]
public class PlayerController : MonoBehaviour {
	
	public float speed = 100;
	public float turnspeed = 5;
	public Rigidbody2D body
    {
        get
        {
            return _body;
        }
    }
    private Rigidbody2D _body;
	private Vector2 heading;


	void Start () {
		_body = gameObject.GetComponent<Rigidbody2D>();
>>>>>>> 92fe595e337f52952ce90304e449426193984da9
	}
	
	void Update () 
	{
		float x = Input.GetAxis("Horizontal");
		float y = Input.GetAxis("Vertical");
		
		heading = new Vector2(x, y);

<<<<<<< HEAD
=======
		//stops player from drifting while no input is being added.
>>>>>>> 92fe595e337f52952ce90304e449426193984da9
		if (heading.sqrMagnitude < 0.1f)
        {
            return;
        }
        else
<<<<<<< HEAD
        {
=======
        { 
        	//turns the player object in the direction of travel.
>>>>>>> 92fe595e337f52952ce90304e449426193984da9
            float angle = Mathf.Atan2(y, x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Slerp(
                transform.rotation,
                Quaternion.Euler(0, 0, angle),
                turnspeed * Time.deltaTime);
        }  
	}

	void FixedUpdate(){
<<<<<<< HEAD
        body.MovePosition(body.position + heading.normalized * speed * Time.deltaTime);
	}

=======
		//this is where the players movement is actually being calculated
        _body.velocity = (heading.normalized * speed);
	}

	// this will disable the player gameObject.
>>>>>>> 92fe595e337f52952ce90304e449426193984da9
	void OnCollisionEnter2D(Collision2D collision){
		if (collision.gameObject.tag == "Enemy"){
			gameObject.SetActive(false);
		}
	}
}
