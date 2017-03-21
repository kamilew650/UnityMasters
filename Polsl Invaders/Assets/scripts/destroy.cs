using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour {

    public int health;

    public AudioClip destroySound;                //takie tam od dzwieku
    private AudioSource source;
    float vol = 0.5f;

    public float destroyTime;
    float coolDownTimer = 0;
    bool over = false;
    bool Visible = true;


    void Awake()
    {
        source = GetComponent<AudioSource>();
        coolDownTimer = destroyTime;
    }


    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Bullet" && Visible == true)
        {
            source.PlayOneShot(destroySound, vol);
            health--;
            Destroy(collider.gameObject);

        }

        if (health==0)
        {
            source.PlayOneShot(destroySound, vol);
            transform.GetComponent<Renderer>().enabled  = false;
            gameObject.tag = "Untagged";
            Visible = false;
            over = true;
            GameController.addPoint();
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
