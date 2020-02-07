using UnityEngine;
using UnityEngine.SceneManagement;

public class SolarSystemPauseMenu : MonoBehaviour
{
    public static bool isPaused = false;
    public static bool controlsActive = false;
    public GameObject pauseMenuUI;
    public GameObject controlsUI;
    public GameObject destination;
   // public GameObject Shuttle;
    //public GameObject shuttleTravelAnchor;

   // public Vector3 currentShuttlePos;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    //    currentShuttlePos = Shuttle.transform.position;
    //    ShuttlePosUpdate();
    //}

    //public void ShuttlePosUpdate()
    //{
    //    Shuttle.transform.position = currentShuttlePos;
    //}
    public void Resume()
    {
        
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
        //shuttleTravelAnchor.transform.position = Shuttle.transform.position;
    }
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }
    public void LoadMenu()
    {
        Time.timeScale = 1f;
        Debug.Log("Menu loading...");
        SceneManager.LoadScene("MainMenu");
        
    }
    public void LoadSettingsMenu()
    {
        Time.timeScale = 1f;
        Debug.Log("Settings menu loading...");
        SceneManager.LoadScene("Settings");
      
    }
    public void LoadControlsMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Controls");
        Debug.Log("Controls menu loading...");
    }

    public void LoadControlsPanel()
    {

        controlsUI.SetActive(true);
        Time.timeScale = 1f;
        controlsActive = true;

    }

    public void CloseControlsPanel()
    {
        controlsUI.SetActive(false);
        Time.timeScale = 1f;
        controlsActive = false;
    }

    public void TravelTo()
    {
 
    
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Player quit game...");
    }
}