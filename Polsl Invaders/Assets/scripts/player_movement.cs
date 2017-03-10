using UnityEngine;
using System.Collections;

public class player_movement : MonoBehaviour {

    float maxSpeed = 10;
    private Rigidbody2D rig;

	// Use this for initialization
	void Start () {
        rig = GetComponent<Rigidbody2D>();
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

       /* float moveHorizontal = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(moveHorizontal, 0, 0);

        rig.MovePosition(transform.position + movement);*/


       transform.Translate(new Vector3( Input.GetAxis("Horizontal") * maxSpeed * Time.deltaTime, 0, 0));
	
	}
}
