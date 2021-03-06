﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject target;
    public GameObject car;
    public float speed = 10;


    // Update is called once per frame
    void Update()
    {
        //moves the vehicule to the target position
        if (car.GetComponent<Reservoir>().stop == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, Time.deltaTime * speed);
        }
        //when the reservoir has reached 0, stops the movements of the car
        if (car.GetComponent<Reservoir>().stop == true)
        {
           car.GetComponent<Movement>().enabled = false;
        }
    }
}
