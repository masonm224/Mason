using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    private float spawnRangeX = 20;
    private float spawnPositionZ = 20;
    private float startDelay = 1;
    private float spawnerTimer = .125f;
    // Start is called before the first frame update
    void Start()
    {
         InvokeRepeating("SpawnEnemy", startDelay, spawnerTimer);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnEnemy() 
        {
            //makes the ball spawn in the wall
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPositionZ);
            //makes the enemy index line, helps the code print all three randomly
            int enemyIndex = Random.Range(0, enemyPrefabs.Length);
            //actually spawns the enemies
            Instantiate(enemyPrefabs[enemyIndex], spawnPos, enemyPrefabs[enemyIndex].transform.rotation);
        
         }
    
}
