using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotationSpeed = 2f;
    public Vector3 rotationDirection = new Vector3();

    // Update is called once per frame
    void Update()
    {
        float smooth = Time.deltaTime * rotationSpeed;
        transform.RotateAround(this.transform.position, rotationDirection.normalized, smooth);
    }
}
