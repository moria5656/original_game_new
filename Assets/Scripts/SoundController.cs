using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    public AudioSource audioSource;

    public AudioClip soundEffect;

    public AudioClip bgm01;
    public AudioClip bgm02;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            audioSource.clip = bgm01;
            audioSource.Play();
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            audioSource.clip = bgm02;
            audioSource.Play();
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            audioSource.Stop();
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            audioSource.PlayOneShot(soundEffect);
        }

        
    }
}
