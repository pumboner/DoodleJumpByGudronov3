using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
   public GameObject platformPrefab;

   public int platformCount = 300;
   void Start ()
   {
        Vector3 spawnPosition = new Vector3();
        for (int i = 0; i < platformCount; i++)
        {
            spawnPosition.y += Random.Range(.3f, 3f);
            spawnPosition.x = Random.Range(-3f, 3f);
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        }

   }
} 
