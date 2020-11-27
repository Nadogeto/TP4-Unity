using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reservoir : MonoBehaviour
{
    public double essence;
    public bool stop;

    float elapsTime = 0f;

    void Update()
    {
        //decrease essence throughout time
        elapsTime += Time.deltaTime;  
        if (elapsTime >= 1f)
        {
            elapsTime = elapsTime % 1f;
            essence = essence - 1;
        }

        Roule(essence);
    }
    
    public Reservoir() { //constructeur
        essence = 10;
        //Debug.Log("Essence :" + essence);
    }

    public double getEssence() {
        return essence;
    }
    
    public void setEssence(double valeur) {
        essence = valeur;
    }

    //indicates that essence has reached 0
    public bool Roule(double consommation)
    {
        if(consommation <= 10)
        {
            stop = false;
        }

        if (consommation == 0)
        {
            stop = true;
        }

        return false;
    }
}
