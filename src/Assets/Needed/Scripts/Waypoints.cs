using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoints : MonoBehaviour
{
    public GameObject[] points;

    public int speed;

    int current;

    private void Update()
    {
        if (Vector3.Distance(points[current].transform.position, transform.position) < 0.1)
        {
            current++;
            if (current >= points.Length)
            {
                current = 0;
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, points[current].transform.position, Time.deltaTime * speed);
    }
}
