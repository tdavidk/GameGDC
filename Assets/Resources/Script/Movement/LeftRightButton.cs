using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LeftRightButton : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    public GameObject player;
    public bool left;

    public void OnPointerDown(PointerEventData eventData)
    {
        if (!left)
        {
            player.GetComponent<PlayerController>().GoRight();
        }

        else if (left)
        {
            player.GetComponent<PlayerController>().GoLeft();
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (!left)
        {
            player.GetComponent<PlayerController>().StopRight();
        }

        else if (left)
        {
            player.GetComponent<PlayerController>().StopLeft();
        }
    }

}
