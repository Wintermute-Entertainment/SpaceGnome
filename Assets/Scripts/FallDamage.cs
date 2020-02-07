using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDamage : MonoBehaviour

{
    public Rigidbody playerRigidBody;
    public float fallDamage = ObjectCollision.fallDamage;
    public float distancetoPlatform;

    public bool playerCollision;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distancetoPlatform = gameObject.transform.position.y * 3;
        if (distancetoPlatform >= 20 && playerCollision==true)
        {
            ApplyFallDamage();
        }

    }


    public void ApplyFallDamage()
    {
        PlayerHealth.health -= fallDamage;
        Debug.Log("Player took: " + fallDamage + "damage.");
    }

    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Player collider entered." + collision);
        playerCollision = true;
    }
    public void OnCollisionExit(Collision collision)
    {
        Debug.Log("Player collider exited." + collision);
        playerCollision = false;
    }
}
