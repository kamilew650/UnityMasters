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


    void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("triggered");
        if (collider.gameObject.tag=="Bullet")
        {
            Destroy(collider.gameObject);
        }
    }

/*    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("kolizja");

        if (collision.gameObject.tag == "Bullet")
        {
            Destroy(collision.gameObject);
        }
    }
*/
}
