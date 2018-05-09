using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour {

    public GameObject item;
    public GameObject tempParent;
    public Transform guide;
    public float scoreValue = 100f;
    // Use this for initialization
    void Start () {
        item.GetComponent<Rigidbody>().useGravity = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnRightClick(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            item.GetComponent<Rigidbody>().useGravity = false;
            item.GetComponent<Rigidbody>().isKinematic = true;
            item.transform.position = guide.transform.position;
            item.transform.rotation = guide.transform.rotation;
            item.transform.parent = tempParent.transform;
            Count.score += scoreValue;
        }
    }

}
