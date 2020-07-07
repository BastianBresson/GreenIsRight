using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public static float obstacleSpeed = 6;

    private Vector3 movementDirection;

    private void Start()
    {
        setMovementDirection();
    }

    private void setMovementDirection()
    {
        movementDirection = -Vector3.forward * obstacleSpeed;
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(movementDirection * Time.deltaTime);
    }


}
