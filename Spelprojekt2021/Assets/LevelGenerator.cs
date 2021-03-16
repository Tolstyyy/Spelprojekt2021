using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject[] levelPrefab;
    public Transform levelGenerator;
    public float spawnDelay = 5.0f;

    void Start()
    {
        InvokeRepeating(nameof(SpawnObject), 0.0f, spawnDelay);
    }

    void SpawnObject()
    {
        // Spawn random level prefab from array
        Instantiate(levelPrefab[Random.Range(0, levelPrefab.Length)], new Vector2(100, -3), Quaternion.identity);
    }           
}
