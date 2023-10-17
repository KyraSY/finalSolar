using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VenusRotatation : MonoBehaviour
{
    [SerializeField]
    float Rotatespeed;
    [SerializeField]
    Vector3 rotationdirection = new Vector3();
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Rotatespeed * rotationdirection * Time.deltaTime);
    }
}