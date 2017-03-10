using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {

    public float maxSpeed=10;
	// Use this for initialization
	void Start () {

	
	}

    void Update()
    {
        transform.Translate(new Vector3(0,maxSpeed * Time.deltaTime, 0));
    }
	
	
}
