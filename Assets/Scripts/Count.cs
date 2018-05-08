using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Count : MonoBehaviour {

    public static float score = 0;
    public float value;
    public Text count;
    private void Awake()
    {
        count = GetComponent<Text>();
        score = 0;
    }
    private void Update()
    {
        count.text = "Score: " + score;
    }
}
