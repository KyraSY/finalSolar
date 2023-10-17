using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunRotate : MonoBehaviour
{
    [SerializeField]
    float rotateSpeed; //Setting a variable/parameter for rotation speed
    [SerializeField]
    Vector3 rotationDirection = new Vector3(); //Calling in a rotation vector for all 3 axis
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotateSpeed * rotationDirection * Time.deltaTime); //We put our variables into the transform rotate's parameters to allow us to make adjustments in unity
    }
}
