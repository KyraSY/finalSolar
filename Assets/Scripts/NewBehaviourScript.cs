using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleMovement : MonoBehaviour
{
    //tLets the user set the speed and radius of the orbit
    public float speed = 2f;
    public float radius = 2f;
    //Creates a new vector with given x, y components and sets z to zero.
    private Vector3 center;
    private float angle;

    void Start()
    {
        //this sets the tranform position and starts the program
        center = transform.position;
    }

    void Update()
    {
        //angle changes over time based on speed in radians, which allows circular movement.
        angle += speed * Time.deltaTime;
        //Calculates the x,y,z position based on cos and sin based on the angle and radius
        float x = center.x + Mathf.Cos(angle) * radius;
        float y = center.y;
        float z = center.z + Mathf.Sin(angle) * radius;
        //Updates position based on new x,y,z
        transform.position = new Vector3(x, y, z);
    }
}




