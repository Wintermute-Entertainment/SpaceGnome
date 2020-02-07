using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EarthShuttleReturn : MonoBehaviour
{
    public GameObject earthPanel;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter(Collision Collision)
    {
        
        if (Collision.gameObject.tag=="Player")
        {
            earthPanel.SetActive(true);
            
        }
    
            
        


    }   
    public void LoadMainScene()
    {
        SceneManager.LoadScene("MainScene");
    }
    public void LoadEarthJump()
    {
        SceneManager.LoadScene("EarthJump");
    }
}
