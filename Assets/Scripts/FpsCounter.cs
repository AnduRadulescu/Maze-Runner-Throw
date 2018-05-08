using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FpsCounter : MonoBehaviour {

    Rect fpsRect;
    GUIStyle style;
	void Start () {
        fpsRect = new Rect(100, 100, 400, 400);
        style = new GUIStyle();
        style.fontSize = 30;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnGUI()
    {
        float fps = 1 / Time.deltaTime;
        GUI.Label(fpsRect, "FPS: " + fps);
    }
}
