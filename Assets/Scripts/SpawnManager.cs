using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    //public int animalIndex;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;

    void Start()
    {

    }

    void Update()
    {
        //Step 2.2
        //if (Input.GetKeyDown(KeyCode.S)) 
        //{
        //    Instantiate(animalPrefabs[animalIndex], new Vector3(0, 0, 20),
        //    animalPrefabs[animalIndex].transform.rotation);
        //}

        //Step 2.3
        //if (Input.GetKeyDown(KeyCode.S))
        //{
        //    int animalIndex = Random.Range(0, animalPrefabs.Length);
        //    Instantiate(animalPrefabs[animalIndex], new Vector3(0, 0, 20),
        //    animalPrefabs[animalIndex].transform.rotation);
        //}

        //Step 2.4
        if (Input.GetKeyDown(KeyCode.S))
        {
            //Random animal generator and random spawn position
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            Instantiate(animalPrefabs[animalIndex], spawnPos,animalPrefabs[animalIndex].transform.rotation);
        }
    }
}
