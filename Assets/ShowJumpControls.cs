using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowJumpControls : MonoBehaviour
{
    public GameObject pausePanel;
    public GameObject controlsPanel;

    // Start is called before the first frame update
    void Start()
    {
        OpenControlsPanel();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OpenControlsPanel()
    {
        controlsPanel.SetActive(true);
    }
}
