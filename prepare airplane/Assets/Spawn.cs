using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject gameObjectToSpawn;
    public float spawnInterval = 1.5f;
    private float lastSpawnTime = 0.0f;
    void Start()
    {
        lastSpawnTime = Time.time;
    }
    void Update()
    {
        if ((Time.time - lastSpawnTime) >= spawnInterval)
        {
            Vector3 pos = new Vector3();
            float random = Random.Range(-1.0f, 1.0f);
            if (random < 0.0f)
            {
                pos.x = transform.position.x + Random.Range(100.0f *
               random, -10.0f);
                pos.y = transform.position.y + Random.Range(80.0f *
               random, 80.0f);
                pos.z = transform.position.z + Random.Range(-10.0f,
               10.0f);
            }
            else if (random > 0.0f)
            {
                pos.x = transform.position.x + Random.Range(10.0f,
               100.0f * random);
                pos.y = transform.position.y + Random.Range(-80.0f,
               80.0f * random);
                pos.z = transform.position.z + Random.Range(-10.0f,
               10.0f);
            }
            GameObject spawnObject = Object.Instantiate(gameObjectToSpawn, pos, transform.rotation);
            Move move = spawnObject.GetComponent<Move>();
            if (move != null) move.speed *= Random.Range(1.0f, 1.5f);
            Object.Destroy(spawnObject, 30.0f);
            lastSpawnTime = Time.time;
        }
    }

}
