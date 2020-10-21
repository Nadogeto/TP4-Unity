using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject target;
    public GameObject car;
    public GameObject canvas;

    private float speed = 10;
    public Reservoir res;

    // Start is called before the first frame update
    void Start()
    {
        car = GameObject.FindGameObjectWithTag("Car");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, Time.deltaTime * speed);
        if (car.GetComponent<Reservoir>().stop == true)
        {
            canvas.SetActive(true);
            Destroy(this);
        }
    }
}
