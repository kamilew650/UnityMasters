using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_Shoot : MonoBehaviour {

    public GameObject enemyBulletPrefab;
    public Vector3 enemyBulletOffset = new Vector3(0, 1, 0);
    public float fireDelay = 1f;

    float coolDownTimer = 0;

    public AudioClip shootSound;            //takie tam od dzwieku
    private AudioSource source;
    float vol = 0.5f;

    void Awake()
    {
        source = GetComponent<AudioSource>();
    }

    // Use this for initialization
    void Start ()
    {
        enemyBulletPrefab.gameObject.tag = "enemyBullet";

    }
	
	// Update is called once per frame
	void Update ()
    {
        coolDownTimer -= Time.deltaTime;
        if(coolDownTimer<=0 && transform.GetComponent<Renderer>().enabled != false && Move_Boss.interactive==true)
        {
            source.PlayOneShot(shootSound, vol);
            coolDownTimer = fireDelay;
            Vector3 offset = transform.rotation * enemyBulletOffset;
            Instantiate(enemyBulletPrefab, transform.position + offset, transform.rotation);
        }

    }
}
