using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculs : MonoBehaviour
{
    //#1 v_addition vecteurs 2D
    Vector2 a_Va;
    Vector2 a_Vb;

    //#2 v_soustraction vecteurs 2D
    Vector2 b_Va;
    Vector2 b_Vb;

    //#3 v_addition vecteurs 3D
    Vector3 c_Va;
    Vector3 c_Vb;

    //#4 v_soustraction vecteurs 3D
    Vector3 d_Va;
    Vector3 d_Vb;

    // Start is called before the first frame update
    void Start()
    {
        //#1
        Vector2 a_Va = new Vector2(5, 8);
        Vector2 a_Vb = new Vector2(3, 2);

        Vector2 a_Vc = a_Va + a_Vb;

        Debug.Log(a_Vc); //résultat addition vecteurs 2D


        //#2
        Vector2 b_Va = new Vector2(-1, -3);
        Vector2 b_Vb = new Vector2(-2, 2);

        Vector2 b_Vc = b_Va - b_Vb;

        Debug.Log(b_Vc); //résultat soustraction vecteurs 2D


        //#3
        Vector3 c_Va = new Vector3(-2, -1, 5);
        Vector3 c_Vb = new Vector3(1, 4, 3);

        Vector3 c_Vc = c_Va + c_Vb;

        Debug.Log(c_Vc); //résultat addition vecteurs 3D


        //#4
        Vector3 d_Va = new Vector3(2, -4, 1);
        Vector3 d_Vb = new Vector3(-1, -1, 3);

        Vector3 d_Vc = d_Va - d_Vb;

        Debug.Log(d_Vc); //résultat soustraction vecteurs 3D
    }
}
