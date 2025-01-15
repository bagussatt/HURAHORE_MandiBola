using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSpawn : MonoBehaviour
{
    public GameObject enemyPrefab;
    private int initialWaveCount = 5;
    private Vector3 spawnPosition = new Vector3(140f, 10f, -40f);

    private int currentWaveCount;

    void Start()
    {
        StartCoroutine(WaitAndStartSpawning());
    }

    IEnumerator WaitAndStartSpawning()
    {
        yield return new WaitForSeconds(30f);
        StartSpawning();
    }

   void StartSpawning()
    {
        StartCoroutine(SpawnEnemies());
    }

    IEnumerator SpawnEnemies()
    {
        while (true)
        {
            yield return new WaitUntil(AllEnemiesDestroyed);

            for (int i = 0; i < currentWaveCount; i++)
            {
                SpawnEnemy();
                yield return new WaitForSeconds(1f);
            }

            currentWaveCount++;
            Debug.Log("Gelombang Boss selesai! Menambah musuh menjadi: " + currentWaveCount);
        }
    }

   void SpawnEnemy()
    {
        Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
    }

   bool AllEnemiesDestroyed()
    {
        return GameObject.FindGameObjectsWithTag("Boss").Length == 0;
    }
}
