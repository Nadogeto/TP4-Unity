using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelRotation : MonoBehaviour
{
    public GameObject car;
    float r_Speed = 100f; //big value to make it noticeable

    // Update is called once per frame
    void Update()
    {
        //rotates the wheel on the x axes
        transform.Rotate(new Vector3(1, 0, 0), r_Speed * Time.deltaTime);

        //if the car has stopped, the wheels will stop turning too
        if (car.GetComponent<Movement>().enabled == false)
        {
            r_Speed = 0;
        }
        //if the car moves, they will rotate
        else
        {
            r_Speed = 100;
        }
    }
}
