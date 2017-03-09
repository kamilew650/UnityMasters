using UnityEngine;
using System.Collections;
using System;

public class StartField_Create : MonoBehaviour {

    
	


    // Use this for initialization
	void Start () {

        CreateEnemy();

    }

    public static void CreateEnemy()
    {
        GameObject enemy = GameObject.CreatePrimitive(PrimitiveType.Cube);

        enemy.GetComponent<Transform>().position = (new Vector3(0, 5, -2.45f));

        enemy.GetComponent<Renderer>().material.color = Color.red;
    }

    // Update is called once per frame
    void Update () {
	
	}
}
