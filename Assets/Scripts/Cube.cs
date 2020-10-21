using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public int id;
    int x;

    // Start is called before the first frame update
    void Start()
    {
        id = 3;
        x = 1;

        Debug.Log(x);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(id);
    }
}
