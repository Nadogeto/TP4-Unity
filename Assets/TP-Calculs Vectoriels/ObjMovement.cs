using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjMovement : MonoBehaviour
{
    //movement speed
    public float m_Speed = 3f;
    //rotation speed
    public float r_Speed = 45;

    // Update is called once per frame
    void Update()
    {
        //moves the object forward (0, 0, 1)
        transform.Translate(Vector3.forward * Time.deltaTime * m_Speed);
        //rotates it
        transform.Rotate(Vector3.up, r_Speed * Time.deltaTime);
    }
}
