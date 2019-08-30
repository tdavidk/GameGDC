using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawn : MonoBehaviour
{
    public GameObject obstacle;
    float randX;
    Vector2 whereToSpawn;
    public float obstacleSpawnRate = 4f;
    float nextSpawn = 0.0f;

    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + obstacleSpawnRate;
            randX = Random.Range(-8f, 8f);
            whereToSpawn = new Vector2(randX, transform.position.y);
            Instantiate(obstacle, whereToSpawn, Quaternion.identity);
        }

    }
    
}
