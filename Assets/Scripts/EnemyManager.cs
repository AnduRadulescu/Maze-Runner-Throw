using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour {

    public GameObject monster;
    public float spawnTime = 1f;
    public Transform[] spawnPoints;
	public void Start () {
        Invoke("Spawn", spawnTime) ;
	}
    void Spawn() 
    {
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);
        Instantiate(monster, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
        //int spawnPointIndex = Random.Range(0, spawnPoints.Length);
        //Instantiate(monster, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
    }
   

}
