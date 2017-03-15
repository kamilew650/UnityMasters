using UnityEngine;
using System.Collections;
using System;

public class playerShooting : MonoBehaviour {

    public GameObject bulletPrefab;
    public Vector3 bulletOffset = new Vector3(0, 5, 0);

    public float fireDelay = 0.5f;
    float coolDownTimer = 0;


    // Use this for initialization
    void Start() {
        bulletPrefab.gameObject.tag = "Bullet";
    }

	
	// Update is called once per frame
	void Update () {

        coolDownTimer -= Time.deltaTime;

        if(Input.GetButton("Jump") && coolDownTimer<=0)
        {
            coolDownTimer = fireDelay;
            Vector3 offset = transform.rotation * bulletOffset;

            GameObject Bullet = Instantiate(bulletPrefab, transform.position+offset, transform.rotation);
        }
	
	}
}


