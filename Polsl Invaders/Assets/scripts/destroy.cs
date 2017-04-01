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
    public GameObject explosion;
    public int value = 1;
    private GameController gameController;


    void Start()
    {
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if(gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent<GameController>();
        }

        if(gameControllerObject == null)
        {
            Debug.Log("nie znaleziono skryptu gameController");
        }

    }


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
            
            if(gameObject.tag!="Untagged")
            {
                Instantiate(explosion, transform.position, transform.rotation);
            }
            if (gameObject.tag == "Enemy")
            {
                gameController.addPoint(value);
            }
            source.PlayOneShot(destroySound, vol);
            transform.GetComponent<Renderer>().enabled  = false;
            gameObject.tag = "Untagged";
            Visible = false;
            over = true;
            //GameController.addPoint();
            
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
