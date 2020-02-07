using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetJump : MonoBehaviour
{
    public GameObject jumpCanvas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter()
    {
        jumpCanvas.SetActive(true);
    }
}
