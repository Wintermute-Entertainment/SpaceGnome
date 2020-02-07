using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour

{
    public static float health = 25;
    static public float currentHealth;

    public GameObject gameOverPanel;

    public static bool dead;

    public static float totalPoints;
    
    

    void Start()
    {
        currentHealth = health;
    }

    // Update is called once per frame
    void Update()
    {
        if (dead)
        {
            print("OH NO, YOU DIED!!!");
            print(Points.finalScore);
        }
        if (currentHealth <= 0)
        {
            Death();
        }
    }
    public void Death()
    {
        dead = true;
        if (PlayerHealth.dead == true)
        {
            totalPoints = Points.currentPoints;
        }

        gameOverPanel.SetActive(true);
        GameOver();
    }
    
    
    public void GameOver()
    {
        
        Debug.Log("Game Over.");
        Destroy(gameObject);
        
    }
    
    //public void OnGUI()
    //{
    //    GUI.Label(new Rect(10, 10, 50, 50), currentHealth.ToString());
    //}

    public void OnCollisionEnter(Collision Collider)
    {
        if (Collider.gameObject.tag == "HealthPowerUp")
        {
            currentHealth += 1;
            
        }
    }

}
