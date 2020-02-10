using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlsMenuBack : MonoBehaviour
{
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        
    }
    public void RestartLevel()
    {
        SceneManager.LoadScene("EarthJump");
    }
}
