using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_Shoot : MonoBehaviour {

    public GameObject enemyBulletPrefab;
    public Vector3 enemyBulletOffset = new Vector3(0, 1, 0);
    public float fireDelay = 1f;
    float coolDownTimer = 0;

    // Use this for initialization
    void Start () {
        enemyBulletPrefab.gameObject.tag = "enemyBullet";

    }
	
	// Update is called once per frame
	void Update () {
        coolDownTimer -= Time.deltaTime;
        if(coolDownTimer<=0)
        {
            coolDownTimer = fireDelay;
            Vector3 offset = transform.rotation * enemyBulletOffset;
            Instantiate(enemyBulletPrefab, transform.position + offset, transform.rotation);
        }

    }
}
