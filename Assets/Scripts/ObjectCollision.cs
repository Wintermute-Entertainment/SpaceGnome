using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectCollision : MonoBehaviour
{
    //public int health = PlayerHealth.health;
    public GameObject gnome;
    public Rigidbody rb;

    static public int damage = 1;
    static public int fallDamage = 3;
    public bool hit;
    private bool hitInfo;

    public ParticleSystem hitParticles;
    public Text armourText;
    
    public void Awake()
    {
        
        rb = GetComponent<Rigidbody>();
        //fallDistance = gameObject.transform.position.y - (gameObject.transform.position.y * 2);
    }

    public void OnCollisionEnter(Collision hitInfo)
    {

        if (hitInfo.gameObject.tag == "Fire")
        {
            SunCube();
        }
        if (hitInfo.gameObject.tag == "Cube" /*&& fallDistance >= 0f*/) //Use Raycast here for fallDistance threshold.
        {
            // ApplyFallDamage();
            GnomeMovement.isIdle = true;
            //Explosions();
        }
        

    }
    public void OnTriggerEnter(Collider other)
    {
        if (other != null)
        {
            Debug.Log(other + "hit.");
            hit = true;
            PlayerHealth.currentHealth -= damage;
            Instantiate(hitParticles).Play(true);
      


        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other != null)
        {
            hit = false;
        }
    }

    public void Update()
    {
     
           
        
        //fallDistance = gnome.transform.position.y +20;

        if (hit == true)
        {
            //PlayerHealth.currentHealth -= damage;
            //if (fallDistance > 20)
            //{
            //    ApplyFallDamage();
            //}
            GnomeMovement.isIdle = true;
        }
        //else if (hit == false)
        //{
        //    GnomeMovement.isFallingIdle = true;
        //}

        armourText.text = PlayerHealth.currentHealth.ToString();  //Why is this causing nullRef errors??
    }
    private void LateUpdate()
    {

    }
    
    public void ApplyFallDamage()
    {
        PlayerHealth.currentHealth -= fallDamage;
        Debug.Log("Player took: " + fallDamage + " fall damage.");
    }
    public void SunCube()
    {
        PlayerHealth.currentHealth = PlayerHealth.health - damage;
        Debug.Log("Player took: " + damage + " fire damage.");
    }

}
