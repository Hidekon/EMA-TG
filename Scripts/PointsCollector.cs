using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsCollector : MonoBehaviour
{
    public int points { get; private set; }

    public void targetHit()
    {
        points++;
        Debug.Log(points);
    }



}
