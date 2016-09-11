using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
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
	}
	
	void Update () 
	{
		float x = Input.GetAxis("Horizontal");
		float y = Input.GetAxis("Vertical");
		
		heading = new Vector2(x, y);

		//stops player from drifting while no input is being added.
		if (heading.sqrMagnitude < 0.1f)
        {
            return;
        }
        else
        { 
        	//turns the player object in the direction of travel.
            float angle = Mathf.Atan2(y, x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Slerp(
                transform.rotation,
                Quaternion.Euler(0, 0, angle),
                turnspeed * Time.deltaTime);
        }  
	}

	void FixedUpdate(){
		//this is where the players movement is actually being calculated
        _body.velocity = (heading.normalized * speed);
	}

	// this will disable the player gameObject.
	void OnCollisionEnter2D(Collision2D collision){
		if (collision.gameObject.tag == "Enemy"){
			gameObject.SetActive(false);
		}
	}
}
