using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjMovement : MonoBehaviour
{
    //vitesse de déplacement
    public float m_Speed = 3f;
    //vitesse de rotation
    public float r_Speed = 45;

    // Update is called once per frame
    void Update()
    {
        //déplace l'objet vers l'avant (0, 0, 1)
        transform.Translate(Vector3.forward * Time.deltaTime * m_Speed);
        //fait tourner l'objet 
        transform.Rotate(Vector3.up, r_Speed * Time.deltaTime);
    }
}
