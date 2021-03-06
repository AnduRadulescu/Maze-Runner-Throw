﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camMouseLook : MonoBehaviour {

    Vector2 mouseLook;
    Vector2 smoothV;
    public float sesitivity = 5.0f;
    public float smoothing = 2.0f;

    GameObject player;
	void Start ()
    {
        player = this.transform.parent.gameObject;	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        var md = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));

        md = Vector2.Scale(md, new Vector2(sesitivity * smoothing, sesitivity * smoothing));
        smoothV.x = Mathf.Lerp(smoothV.x, md.x, 1f / smoothing);
        smoothV.y = Mathf.Lerp(smoothV.y, md.y, 1f / smoothing);
        mouseLook += smoothV;

        transform.localRotation = Quaternion.AngleAxis(-mouseLook.y, Vector3.right);
        player.transform.localRotation = Quaternion.AngleAxis(mouseLook.x, player.transform.up);
    }
}
