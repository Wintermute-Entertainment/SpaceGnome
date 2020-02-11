using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
    //AUDIO
    public AudioClip[] audioClips;
    public AudioSource audioSource;
    public AudioListener audioListener;
    //public AudioClip explosion1;
    //public AudioClip explosion2;
    //public AudioClip explosion3;

    void Awake()
    {
        audioListener = GetComponent<AudioListener>();
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    public void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            PlayExplosion();
        }
            
    }
    void PlayExplosion()
    {
        audioSource.clip = audioClips[Random.Range(0, audioClips.Length)];
        audioSource.PlayOneShot(audioSource.clip, 0.7f);


    }
}
