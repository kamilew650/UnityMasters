using UnityEngine;
using System.Collections;

public class player_movement : MonoBehaviour {

    float maxSpeed = 10;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

       

        transform.Translate(new Vector3(0, Input.GetAxis("Horizontal") * maxSpeed * Time.deltaTime, 0));
	
	}
}
