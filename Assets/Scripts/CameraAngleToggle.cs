﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAngleToggle : MonoBehaviour
{
    public Camera MainCamera;
    public Camera TopCamera;
    public Camera FrontCamera;

    private int CameraState = 1;

    //public GameObject cockPitCanvas;

    // Use this for initialization
    void Start()
    {
        //MainCamera = Camera.main;
        CameraState = 1;
        MainCamera.enabled = true;      
        TopCamera.enabled = false;
        FrontCamera.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.C))
        {
            if (CameraState == 1)
            {
                CameraState = 2;
                MainCamera.enabled = false;
                TopCamera.enabled = true;
                //cockPitCanvas.SetActive(false);
            }

            else if (CameraState == 2)
            {
                CameraState = 3;
                TopCamera.enabled = false;
                FrontCamera.enabled = true;
                //cockPitCanvas.SetActive(true);
            }

            else if (CameraState == 3) {
                CameraState = 1;
                FrontCamera.enabled = false;
                MainCamera.enabled = true;
                //cockPitCanvas.SetActive(false);
            }
        }

    }
}
