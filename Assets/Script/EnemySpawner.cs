using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab; 
    private int currentWaveCount = 10;
    private Vector3 spawnPosition = new Vector3(140f, 5f, -40f);

    void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    IEnumerator SpawnEnemies()
    {
        while (true) 
        { 
            yield return new WaitUntil(() => AllEnemiesDestroyed());

          
            for (int i = 0; i < currentWaveCount; i++)
            {
                SpawnEnemy();  
                yield return new WaitForSeconds(1f); 
            }

            
            currentWaveCount++;
            Debug.Log("Gelombang selesai! Menambah musuh menjadi: " + currentWaveCount);
        }
    }

    void SpawnEnemy()
    {
     
        Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
    }

    bool AllEnemiesDestroyed()
    { 
        return GameObject.FindGameObjectsWithTag("Enemy").Length == 0;
    }
}
