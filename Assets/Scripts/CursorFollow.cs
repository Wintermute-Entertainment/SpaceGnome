using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorFollow : MonoBehaviour
{
    private Camera cam;
    public Camera cursorFollowCam;

    void Start()
    {

        cam = Camera.main;
    }

    void OnGUI()
    {
        Vector3 point = new Vector3();
        Event currentEvent = Event.current;
        Vector2 mousePos = new Vector2();

        // Get the mouse position from Event.
        // Note that the y position from Event is inverted.
        mousePos.x = currentEvent.mousePosition.x;
        mousePos.y = cursorFollowCam.pixelHeight - currentEvent.mousePosition.y;

        point = cursorFollowCam.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, cursorFollowCam.nearClipPlane));

        GUILayout.BeginArea(new Rect(20, 20, 250, 120));
        GUILayout.Label("Screen pixels: " + cursorFollowCam.pixelWidth + ":" + cursorFollowCam.pixelHeight);
        GUILayout.Label("Mouse position: " + mousePos);
        GUILayout.Label("World position: " + point.ToString("F3"));
        GUILayout.EndArea();
    }

}
