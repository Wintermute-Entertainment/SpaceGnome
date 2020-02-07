using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boost : MonoBehaviour
{
    public static float boost = Points.boost;

    public GameObject fireworksObject;
    public ParticleSystem boostExplosionParticles;

    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            Points.boost += 1000f;
            Debug.Log("+1000 Boost.");
            Points.points += 1000f;
            Debug.Log("+1000 Points.");
            GnomeMovement.isIdle = true;
            fireworksObject.SetActive(true);

            if (collider.gameObject.tag == "HealthPowerUp")
            {
                PlayerHealth.currentHealth += 1f;
                Debug.Log("Gained 1 Heatlh.");
            }

            Destroy(gameObject);
        }
    }
}
