using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    // Apparently serializefield makes it so I can edit these easily without making them public, so pretty cool (This means you have to edit the rotation speed and direction in the editor still)
    [SerializeField]
    float rotationSpeed;
    [SerializeField]
    Vector3 rotationDirection = new Vector3();
    // The thing above this lets you control the direction, remember that me.

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // now it can actually rotate....
        transform.Rotate(rotationSpeed * rotationDirection * Time.deltaTime);
    }
}
