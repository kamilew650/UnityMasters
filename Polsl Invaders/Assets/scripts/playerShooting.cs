using UnityEngine;
using System.Collections;

public class playerShooting : MonoBehaviour {

    public GameObject bulletPrefab;

    public float fireDelay = 0.5f;
    float coolDownTimer = 0;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        coolDownTimer -= Time.deltaTime;

        if(Input.GetButton("Fire1") && coolDownTimer<=0)
        {
            coolDownTimer = fireDelay;

            Instantiate(bulletPrefab,new Vector3(transform.position.x,transform.position.y,transform.position.z));
        }
	
	}
}
