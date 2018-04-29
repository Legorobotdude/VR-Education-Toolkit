using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour {

	
    [SerializeField] float speed = 10f;
    [SerializeField] bool xAxis = false;
    [SerializeField] bool yAxis = false;
    [SerializeField] bool zAxis = false;

    void Update ()
    {
        if (xAxis)
        {
            transform.Rotate(Vector3.right, speed * Time.deltaTime);
        }
        
        if (yAxis)
        {
             transform.Rotate(Vector3.up, speed * Time.deltaTime);
        }
        if (zAxis)
        {
            transform.Rotate(Vector3.forward, speed * Time.deltaTime);
        }
    }
}
