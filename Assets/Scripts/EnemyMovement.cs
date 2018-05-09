using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour {

    public GameObject hitParticles;
    public float scoreValue = -10;
    EnemyManager spawn;

    Transform player;
    NavMeshAgent nav;

    public GameObject monster;
 
    public Transform[] spawnPoints;

    void Awake () {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        nav = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
        nav.SetDestination(player.position);
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Instantiate(hitParticles, transform.position, transform.rotation);
            Count.score += scoreValue;

            int spawnPointIndex = Random.Range(0, spawnPoints.Length);
            Instantiate(monster, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);

        // playerAudio.Play();
    }
    }
    public void Dissappear()
    {
        GetComponent<NavMeshAgent>().enabled = false;
        GetComponent<Rigidbody>().isKinematic = true;
        Destroy(gameObject, 0.1f);
       // spawn.Respawn();
    }
}
