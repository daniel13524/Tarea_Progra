using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstables : MonoBehaviour
{
    public GameObject[] waypoints;
    public float speed;
    private int waypointsIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveObstacle();
    }

    void MoveObstacle()
    {
        if(Vector3.Distance(transform.position,waypoints[waypointsIndex].transform.position) < 0.1f)
        {
            waypointsIndex++;

            if(waypointsIndex >= waypoints.Length)
            {
                waypointsIndex = 0;
            }
        }

        transform.position = Vector3.MoveTowards(transform.position, waypoints[waypointsIndex].transform.position, speed * Time.deltaTime);
    }
}
