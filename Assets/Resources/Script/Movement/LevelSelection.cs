using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSelection : MonoBehaviour
{
    float[] posX = new float[] { -4.75f, -20f };
    int idx;

    public void MoveRight()
    {
        if (idx < posX.Length - 1)
        {
            idx++;
        }
    }

    public void MoveLeft()
    {
        if (idx > 0)
        {
            idx--;
        }
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(posX[idx], transform.position.y), 50 * Time.deltaTime);
    }
}