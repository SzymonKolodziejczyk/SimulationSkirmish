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
 
     void Start()
     {
         timer = 0;
     }
 
     private void Update()
     {
         timer += Time.deltaTime;
         if(timer >= spawnTime)
         {
             spawnTime = Random.Range(minTimeSpawn, maxTimeSpawn);
             Instantiate(spawnObject, spawnPoint, Quaternion.identity);
             timer = 0;
         }
     }
}
