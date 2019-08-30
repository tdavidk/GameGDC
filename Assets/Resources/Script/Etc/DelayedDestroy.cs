using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayedDestroy : MonoBehaviour
{
    IEnumerator DelayDestroy()
    {
        yield return new WaitForSeconds(1);
        Destroy(this.gameObject);
    }
	
	void OnCollisionEnter2D (Collision2D col)
    {
        if (col.gameObject.CompareTag("Obstacle"))
        {
            StartCoroutine(DelayDestroy());
        }

        if (col.gameObject.CompareTag("Coin"))
        {
            StartCoroutine(DelayDestroy());
        }
    }
}
