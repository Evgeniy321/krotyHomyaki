using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoints : MonoBehaviour
{
    [SerializeField] public Transform[] points;
    
    
    public Transform GetNextPoint(int index)
    {
        if(index >= points.Length) return null;
        else return points[index];
    }
}
