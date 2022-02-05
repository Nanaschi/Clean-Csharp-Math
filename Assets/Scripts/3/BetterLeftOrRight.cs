using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BetterLeftOrRight : MonoBehaviour
{
    public Transform youTrans;
    public Transform wayPointTrans;

    void Update()
    {
//The right direction of the direction you are facing
        Vector3 youDir = youTrans.right;

//The direction from you to the waypoint
        Vector3 waypointDir = wayPointTrans.position - youTrans.position;

//The dot product between the vectors
        float dotProduct = Vector3.Dot(youDir, waypointDir);

//Now we can decide if we should turn left or right
        if (dotProduct > 0f)
        {
            Debug.Log("Turn right");
        }
        else
        {
            Debug.Log("Turn left");
        }
    }
}
