using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyPlayer : MonoBehaviour {

    public int health;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		

	}
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "enemyBullet")
        {
            health--;
            Destroy(collider.gameObject);

        }

        if (collider.gameObject.tag=="Enemy")
        {
            health -= 2;
            Destroy(collider.gameObject);
        }

        if (health == 0)
        {
            Destroy(gameObject);
            GameController.addPoint();
        }
    }
}
