using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class SoundController : MonoBehaviour {

    public AudioClip shootSound;           //obiekty przechowujace dzwieki
    public AudioClip shootSound2;
    public static AudioClip destroySound = source.GetComponent<AudioClip>();

    private static int i = 0;
    private static AudioSource source;                 //obiekt chyba do komunikacji z "glosnikiem"
    private static float vol = 0.5f;                   // glosnosc

    void Awake()
    {
        source = GetComponent<AudioSource>();
    }

    public void shoot1()
    {
        source.clip = shootSound;
        source.Play();
    }

    public static void add()
    {
        i++;
    }

    void Update()
    {

        if (i > 0)
        {
            SoundController.destroy1();
            i--;
        }

    }

    public static void destroy1()
    {
        
        source.PlayOneShot(destroySound, vol);
    }
}
