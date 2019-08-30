using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawn : MonoBehaviour
{
    public GameObject coin;
    float randX;
    Vector2 whereToSpawn;
    public float coinSpawnRate = 4f;
    float nextSpawn = 0.0f;

    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + coinSpawnRate;
            randX = Random.Range(-8f, 8f);
            whereToSpawn = new Vector2(randX, transform.position.y);
            Instantiate(coin, whereToSpawn, Quaternion.identity);
        }
    }
}
