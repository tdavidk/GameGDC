using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyItemPlayer : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Obstacle"))
        {
            PointCounter.coinAmount -= 1;
            Destroy(col.gameObject);
        }

        if (col.gameObject.CompareTag("Coin"))
        {
            PointCounter.coinAmount += 1;
            Destroy(col.gameObject);
        }
    }
}
