using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public float speed = 3;
    public int stepsAhead = 1;
    private PlayerController player;

    void Start()
    {
        player = GameObject.FindObjectOfType(typeof(PlayerController)) as PlayerController;
    }

    void FixedUpdate()
    {
        Vector3 pos = Vector3.Lerp(
            transform.position, 
            player.transform.position + (Vector3)player.body.velocity *stepsAhead * Time.deltaTime, 
            speed * Time.deltaTime);

        pos.z = transform.position.z;

        transform.position = pos;
    }
}//EndOfScript
