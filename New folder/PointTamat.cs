using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointTamat : MonoBehaviour
{
    Text Point;

    private void Start()
    {
        Point = GetComponent<Text>();
    }

    private void Update()
    {
        Point.text = ("Point = ") + PointCounter2.score.ToString();
    }
}
