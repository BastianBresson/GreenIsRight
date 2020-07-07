using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject spawnPoint = default;

    [SerializeField] List<GameObject> obstacles = default; 

    public float spawnFrequency = 5f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnCoroutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnFrequency);

            Instantiate(obstacles[Random.Range(0, obstacles.Count)], spawnPoint.transform.position, Quaternion.identity);
        }
    }
}
