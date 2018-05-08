using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class menu : MonoBehaviour {

    public Button playB;


	// Use this for initialization
	void Start () {
        playB.onClick.AddListener(() =>
       {
           Application.LoadLevel("Level01");
       });
	}
}
