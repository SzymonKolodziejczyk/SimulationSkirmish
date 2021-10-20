using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject spawnObject;
    private Vector3 spawnPoint;

    public int minTimeSpawn = 2; // Minimum time needed to spawn agent
    public int maxTimeSpawn = 10; // Maximum time needed to spawn agent
    float timer = 0; // Game Time

    private float spawnTime; // Time needed to spawn agent

    private int spawnCount; // Count how many agents were spawned
    public int maxSpawn = 30; // Maximum amount of agents on screen

    public string objectName= "Agent"; // Change the name of agent
 
    void Start()
    {
        timer = 0;
    }

    private void Update()
    {
        if(spawnCount < maxSpawn){
            timer += Time.deltaTime;
            if(timer >= spawnTime)
            {
                spawnTime = Random.Range(minTimeSpawn, maxTimeSpawn);
                var clone = Instantiate(spawnObject, spawnPoint, Quaternion.identity);
                clone.name = objectName + " " + spawnCount;
                timer = 0;
                spawnCount++;
            }
        }
    }
}
