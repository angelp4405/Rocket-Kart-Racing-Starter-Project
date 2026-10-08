using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    // Drive - a public method which takes in an axis value from the player
    // and stores that calue to be used later to control forward / backward
    // movement.

    //Example:
    private float driveAxis;
    public void Drive(float driveAxis)
    {
        this.driveAxis = Mathf.Clamp(driveAxis, -1f, 1f);
    }

    // Brake - a public method which takes in an axis value from the player
    // and stores that value to be used later to control braking

    // Turn - a public method which takes in an axis value from the plater
    // and stores that value to be used later to control turning.

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
