using UnityEngine;
using System.Collections;
using System;

public class playerShooting : MonoBehaviour {

    public GameObject bulletPrefab;
    public Vector3 bulletOffset = new Vector3(0, 5, 0);
    public float fireDelay = 0.5f;
    float coolDownTimer = 0;

    public AudioClip shootSound;                //takie tam od dzwieku
    private AudioSource source;
    float vol = 0.5f;

    void Awake()
    {
        source = GetComponent<AudioSource>();
    }



    // Use this for initialization
    void Start() {
        bulletPrefab.gameObject.tag = "Bullet";
    }

	
	// Update is called once per frame
	void Update () {

        coolDownTimer -= Time.deltaTime;

        if(Input.GetButton("Jump") && coolDownTimer<=0)
        {
            source.PlayOneShot(shootSound, vol);
            coolDownTimer = fireDelay;
            Vector3 offset = transform.rotation * bulletOffset;

            Instantiate(bulletPrefab, transform.position+offset, transform.rotation);
        }
	
	}
}


