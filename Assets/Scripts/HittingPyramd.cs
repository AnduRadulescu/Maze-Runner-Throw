using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HittingPyramd : MonoBehaviour {

    ParticleSystem hitParticles;
    MeshCollider meshCollider;
    AudioSource hitSound;
	void Awake () {
        hitParticles = GetComponentInChildren<ParticleSystem>();
        meshCollider = GetComponent<MeshCollider>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void TakeDamage(Vector3 hitPoint)
    {
        hitParticles.Play();
        hitParticles.transform.position = hitPoint;
        hitParticles.Play();
    }
}
