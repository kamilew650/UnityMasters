using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyPlayer : MonoBehaviour {

    public int health;

    public AudioClip destroySound;            //takie tam od dzwieku
    private AudioSource source;
    float vol = 0.5f;

    public float destroyTime;
    public float coolDownTimer = 0;
    bool over = false;
    bool Visible = true;


    void Awake()
    {
        source = GetComponent<AudioSource>();
        coolDownTimer = destroyTime;
    }


    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "enemyBullet")
        {
            source.PlayOneShot(destroySound, vol);
            health--;
            Destroy(collider.gameObject);

        }

        if (collider.gameObject.tag=="Enemy")
        {
            source.PlayOneShot(destroySound, vol);
            health -= 2;
            Destroy(collider.gameObject);
        }

        if (health <= 0)
        {
            source.PlayOneShot(destroySound, vol);
            transform.GetComponent<Renderer>().enabled = false;
            gameObject.tag = "Untagged";
            Visible = false;
            over = true;
        }
    }

    void Update()
    {
        if (over == true)
        {
            coolDownTimer -= Time.deltaTime;
        }

        if (coolDownTimer <= 0)
        {
            Destroy(gameObject);
        }
    }

}
