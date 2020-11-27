using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deplacement : MonoBehaviour
{
    public GameObject car;

    // Update is called once per frame
    void Update()
    {
        float speed = car.GetComponent<Movement>().speed;
        double essence = car.GetComponent<Reservoir>().essence;

        if (essence > 0)
        {
            if (Input.GetKeyDown(KeyCode.DownArrow) && speed > 0)
            {
                car.GetComponent<Movement>().speed--;
            }
            else if(Input.GetKeyDown(KeyCode.UpArrow) && speed < 10)
            {
                car.GetComponent<Movement>().speed++;
            }
        }
        Debug.Log(speed);
    }
}
