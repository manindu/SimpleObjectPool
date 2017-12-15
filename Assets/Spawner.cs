using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    [SerializeField] GameObject cubePrefab;
    [SerializeField] int poolSize = 20;

    void Start()
    {
        PoolManager.instance.CreatePool(cubePrefab, poolSize);
        InvokeRepeating("SpawnCubes", 1f, 2f);
    }

    void SpawnCubes()
    {
        GameObject cubeObject = PoolManager.instance.GetObject(cubePrefab);
        cubeObject.transform.position = Vector3.zero;
        cubeObject.SetActive(true);
    }
}
