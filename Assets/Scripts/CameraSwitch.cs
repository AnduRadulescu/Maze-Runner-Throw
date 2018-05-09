using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour {

    public GameObject cameraOne;
    public GameObject cameraTwo;

    AudioListener c1audio;
    AudioListener c2audio;

    // Use this for initialization
    void Start () {
        c1audio = cameraOne.GetComponent<AudioListener>();
        c2audio = cameraTwo.GetComponent<AudioListener>();

        cameraPositionChange(PlayerPrefs.GetInt("CameraPosition"));
	}
	
	// Update is called once per frame
	void Update () {
        swithcCamera();
	}

    public void camreaPositionM()
    {
        camreaChangeCounter();
    }
    void swithcCamera()
    {
        if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.LeftAlt))
        {
            camreaChangeCounter();
        }
    }
    void camreaChangeCounter()
    {
        int cameraPositonCounter = PlayerPrefs.GetInt("CameraPosition");
        cameraPositonCounter++;
        cameraPositionChange(cameraPositonCounter);
    }
    void cameraPositionChange(int camPosition)
    {
        if(camPosition > 1)
        {
            camPosition = 0;
        }
        PlayerPrefs.SetInt("CameraPosition", camPosition);
        //set camera position 1 
        if(camPosition == 0)
        {
            cameraOne.SetActive(true);
            c1audio.enabled = true;

            c2audio.enabled = false;
            cameraTwo.SetActive(false);
        }
        //set camera position 2
        if (camPosition == 1)
        {
            cameraTwo.SetActive(true);
            c2audio.enabled = true;

            c1audio.enabled = false;
            cameraOne.SetActive(false);
        }
    }



}
