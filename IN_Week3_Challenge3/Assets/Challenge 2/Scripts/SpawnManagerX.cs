﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float spawnInterval;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnRandomBall", startDelay);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall()
    {
        //Generate random ball index and random spawn position

        int ballIndex = Random.Range(0, ballPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
       
        //instantiate randomball at random spawn location
        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);

        //Generate random time between 0 and 4 for ball to spawn 
        spawnInterval = Random.Range(0f, 4f);
        Invoke("SpawnRandomBall", spawnInterval);
    }
    
    


}
