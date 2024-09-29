using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    private WayPoints wayPoints;
    private int index;
    private Transform target;
    private float speed;
    private float maxspeed;

    public void Setup(WayPoints newway, float newspeed)
    {
        wayPoints = newway;
        speed = newspeed;
        maxspeed = speed;
        index = 0;
        target = GetNextTarget();
    }
    private Transform GetNextTarget()
    {
        index++;
        return wayPoints.GetNextPoint(index);
    }

    public void Go()
    {
        speed = maxspeed;
    }

    public void Stop()
    {
        speed = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(!target) return;
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed*Time.deltaTime);// calc collision with shere and stop
        if(Vector3.Distance(transform.position, target.position) < 0.1f)
        {
            target = GetNextTarget();
        }
    }
}
