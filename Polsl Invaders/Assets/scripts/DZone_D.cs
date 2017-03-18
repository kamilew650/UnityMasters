using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DZone_D : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("triggered");
        if (collider.gameObject.tag == "Enemy" || collider.gameObject.tag=="enemyBullet")
        {
            Destroy(collider.gameObject);
        }
    }
}
