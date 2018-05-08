using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ballThrow : MonoBehaviour
{
    public GameObject ball1;
    public GameObject ball2;
    public GameObject ball3;
    public GameObject ball4;
    public GameObject ball5;
    

    public GameObject playerCamera;
    public float ballDistance;
    public float ballThrowingForce;
    public GameObject hitParticles;
    public float scoreValue = 50f;
    public float throwingRate;

    private float nextFire;
    private bool holdingball = true;
    private bool holdingball2 = true;
    private bool holdingball3 = true;
    private bool holdingball4 = true;
    private bool holdingball5 = true;

    private void Start()
    {
        ball1.GetComponent<Rigidbody>().useGravity = false;
        ball2.GetComponent<Rigidbody>().useGravity = false;
        ball3.GetComponent<Rigidbody>().useGravity = false;
        ball4.GetComponent<Rigidbody>().useGravity = false;
        ball5.GetComponent<Rigidbody>().useGravity = false;

    }
    
    void Update()
    {
        GameObject[] balls = new GameObject[5];
        balls[0] = ball1;
        balls[1] = ball2;
            if (Input.GetMouseButtonDown(0) && holdingball)
            {
                holdingball = false;
                //nextFire = Time.time + throwingRate;
                ball1.GetComponent<Rigidbody>().useGravity = true;
                ball1.GetComponent<Rigidbody>().AddForce(playerCamera.transform.forward * ballThrowingForce);
            }
            else {
                if (Input.GetMouseButtonDown(0) && holdingball2)
                {
                    holdingball2 = false;
                    ball2.GetComponent<Rigidbody>().useGravity = true;
                    ball2.GetComponent<Rigidbody>().AddForce(playerCamera.transform.forward * ballThrowingForce);
                }
            else { if (Input.GetMouseButtonDown(0) && holdingball3)
                    {
                        holdingball3 = false;
                        ball3.GetComponent<Rigidbody>().useGravity = true;
                        ball3.GetComponent<Rigidbody>().AddForce(playerCamera.transform.forward * ballThrowingForce);
                    }
                else
                {
                    if (Input.GetMouseButtonDown(0) && holdingball4)
                    {
                        holdingball4 = false;
                        ball4.GetComponent<Rigidbody>().useGravity = true;
                        ball4.GetComponent<Rigidbody>().AddForce(playerCamera.transform.forward * ballThrowingForce);
                    }
                    else
                    { 
                        if (Input.GetMouseButtonDown(0) && holdingball5)
                        {
                            holdingball5 = false;
                            ball5.GetComponent<Rigidbody>().useGravity = true;
                            ball5.GetComponent<Rigidbody>().AddForce(playerCamera.transform.forward * ballThrowingForce);
                        }
                    }
                }
                }
            }
            
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag.Equals("Pyramid_1") == true)
        {
            Instantiate(hitParticles, transform.position, transform.rotation);
            Count.score += scoreValue; 
        }
        return;
    }
}
