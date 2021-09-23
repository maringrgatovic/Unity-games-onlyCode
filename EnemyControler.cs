using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControler : MonoBehaviour
{
    public Transform[] patrolPoints;
    public float speed;

    int currentPoint;

    void Start()
    {
        currentPoint = 0;
        transform.position = patrolPoints[currentPoint].position;

    }

    void Update()
    {
        if (transform.position == patrolPoints[currentPoint].position)
        {
            currentPoint++;
            
        }
        if(currentPoint >= patrolPoints.Length)
        {
            currentPoint = 0;
        }
        transform.position = Vector3.MoveTowards(transform.position,
            patrolPoints[currentPoint].position, speed*Time.deltaTime);
    }
}
