using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyItemGround : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Obstacle"))
        {
            Destroy(col.gameObject);   
        }

        if (col.gameObject.CompareTag("Coin"))
        {
            Destroy(col.gameObject);
        }
    }
}
