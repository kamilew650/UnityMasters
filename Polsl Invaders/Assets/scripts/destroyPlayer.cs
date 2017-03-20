using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyPlayer : MonoBehaviour {

    public int health;

    public AudioClip destroySound;            //takie tam od dzwieku
    private AudioSource source;
    float vol = 0.5f;

    void Awake()
    {
        source = GetComponent<AudioSource>();
    }


    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "enemyBullet")
        {
            source.PlayOneShot(destroySound, vol);
            health--;
            Destroy(collider.gameObject);
            SoundController.add();

        }

        if (collider.gameObject.tag=="Enemy")
        {
            source.PlayOneShot(destroySound, vol);
            health -= 2;
            Destroy(collider.gameObject);
            SoundController.destroy1();
        }

        if (health == 0)
        {
            source.PlayOneShot(destroySound, vol);
            Destroy(gameObject);
            GameController.addPoint();
            SoundController.destroy1();
        }
    }
}
