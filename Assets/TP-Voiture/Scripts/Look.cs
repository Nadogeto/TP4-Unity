using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Look : MonoBehaviour
{
    public Transform car;
    public Vector3 car_Pos;
    float speed = 10;

    // Update is called once per frame
    void Update()
    {
        car_Pos = car.transform.position; //formalization

        //calculate distance to move
        float step = speed * Time.deltaTime; 
        //moves the camera along the z axes only
        //in order to follow the car while staying parallel to it
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x,transform.position.y, car_Pos.z), step); 
    }
}
