using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject car;
    public GameObject cam;
    public GameObject canvas;
    public GameObject carStartPoint;
    public GameObject camStartPoint;

    // Update is called once per frame
    void Update()
    {
        if (car.GetComponent<Reservoir>().stop == true)
        {
            canvas.SetActive(true);
        }
    }

    //resets the essence count of Reservoir and the position of the vehicle and its movements
    public void RestartCar()
    {
        car.GetComponent<Movement>().enabled = true;
        car.transform.position = carStartPoint.transform.position;
        car.GetComponent<Reservoir>().essence = 10;

        cam.transform.position = camStartPoint.transform.position;
    }

    //reloads the scene(not the best practice)
    //the best practice => use active scene and restart the song
    public void RestartGame()
    {
        SceneManager.LoadScene("Voiture");
    }
}
