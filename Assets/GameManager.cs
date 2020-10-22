using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject car;
    public GameObject canvas;
    public GameObject startPoint;

    // Update is called once per frame
    void Update()
    {
        if (car.GetComponent<Reservoir>().stop == true)
        {
            canvas.SetActive(true);
        }
    }

    public void RestartCar()
    {
        car.transform.position = startPoint.transform.position;
        car.GetComponent<Reservoir>().essence = 10;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Prototype 1");
    }
}
