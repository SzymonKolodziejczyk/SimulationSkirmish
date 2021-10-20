using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject spawnObject;
    private Vector3 spawnPoint;
    public int minTimeSpawn = 2;
    public int maxTimeSpawn = 10;
    float timer = 0;
    private float spawnInterval;
    private float spawnTime;
    private int spawnCount;
    public int maxSpawn = 30;
    public string objectName= "Agent";
 
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
