﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectKiller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DestroyObject();
    }
    private void OnCollisionEnter(Collision collision)
    {
        
    }
    public void DestroyObject()
    {
        new WaitForSeconds(3);
        Destroy(gameObject);
    }
}
