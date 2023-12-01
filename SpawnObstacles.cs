using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{
    [SerializeField] private GameObject[] obstacles;
    [SerializeField] private float intialSpawnRate = 2f;
    [SerializeField] private float currentSpawnRate;
    [SerializeField] private float minSpawnRate = 0.25f;
    [SerializeField] private float spawnDecreaseRate = 0.5f;

    void Start()
    {
        currentSpawnRate = intialSpawnRate;
        InvokeRepeating("Spawn", 0f, currentSpawnRate);
    }
    void Update()
    {
       currentSpawnRate -= spawnDecreaseRate*Time.deltaTime;
       currentSpawnRate = Mathf.Max(currentSpawnRate,minSpawnRate);
    }

    void Spawn()
    {
        GameObject obstaclePrefab = obstacles[Random.Range(0, obstacles.Length)];
        Instantiate(obstaclePrefab, transform.position, Quaternion.identity);
    }
}
