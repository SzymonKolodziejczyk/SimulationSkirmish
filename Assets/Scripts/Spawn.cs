using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    public GameObject spawnObject;
     public Vector3 spawnPoint;
     public int minTimeSpawn = 2;
     public int maxTimeSpawn = 8;
     float timer = 0;
 
     void Start()
     {
         timer = 0;
     }
 
     private void Update()
     {
         timer += Time.deltaTime;
         Spawning();
     }
 
     void Spawning()
     {
         if (timer >= minTimeSpawn)
         {
             Instantiate(spawnObject, spawnPoint, Quaternion.identity);
             timer = 0;
         }
     }
}
