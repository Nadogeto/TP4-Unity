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

    //resets the essence count of Reservoir and the position of the vehicle 
    public void RestartCar()
    {
        car.transform.position = startPoint.transform.position;
        car.GetComponent<Reservoir>().essence = 10;
    }

    //reloads the scene(not the best practice)
    //the best practice => use active scene
    public void RestartGame()
    {
        SceneManager.LoadScene("Voiture");
    }
}
