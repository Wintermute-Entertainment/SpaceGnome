using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShuttleCollision : MonoBehaviour
{
    public ParticleSystem explosion;

    void Update()
    {
        if (explosion.isPlaying)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        foreach (ContactPoint contact in collision.contacts)
        {
            explosion.Play();
            
        }
        
    }
}
