﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void QuitGame()
    {
        Debug.Log("User quit application.");
        Application.Quit();
    }
    public void SettingsMenuButton()
    {
        SceneManager.LoadScene("Settings");
    }

    public void ControlsMenuButton()
    {
        SceneManager.LoadScene("Controls");
    }
}