using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject target;
    public GameObject car;

    private float speed = 10;
    public Reservoir res;

    // Update is called once per frame
    void Update()
    {
        //moves the vehicule to the target position
        if (car.GetComponent<Reservoir>().stop == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, Time.deltaTime * speed);
        }
        //when the reservoir has reached 0, stops the car
        if (car.GetComponent<Reservoir>().stop == true)
        {
            transform.position = target.transform.position;//not the best practice
        }
    }
}
