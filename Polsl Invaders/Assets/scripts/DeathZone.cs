using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("triggered");
        if (collider.gameObject.tag == "Bullet")
        {
            Destroy(collider.gameObject);
        }
    }
}
