using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour {
    public int health;

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Bullet")
        {
            health--;
            Destroy(collider.gameObject);

        }

        if (health==0)
        {
            Destroy(gameObject);
            GameController.addPoint();
        }
    }
}
