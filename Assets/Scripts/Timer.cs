using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour {
    public float timeRemaining = 60;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timeRemaining -= Time.deltaTime;
	}

    private void OnGUI()
    {
        if(timeRemaining > 0)
        { 
            GUI.contentColor = Color.red;
            GUI.Label(new Rect( 50 ,50, 100, 50), "Tiemr :" + timeRemaining,"color");

        }
        else
        {
            changeScene("EndScene");
        }
    }
    public void changeScene(string sceneName)
    {
        Application.LoadLevel(sceneName);
    }
}
