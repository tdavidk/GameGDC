using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointCounter : MonoBehaviour
{
    Text text;
    public GameObject panelGameOver;
    public static int coinAmount = 3;

    private void Start()
    {
        text = GetComponent<Text> ();
    }

    private void Update()
    {
        text.text = ("Point = ") + coinAmount.ToString();

        if (coinAmount == 0)
        {
            panelGameOver.SetActive(true);
        }        
    }
}
