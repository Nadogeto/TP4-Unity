using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reservoir : MonoBehaviour
{
    private double essence;
    public bool stop = false;
    
    void Update()
    {    
        essence -= Time.deltaTime;
    }
    
    public Reservoir() { //Constructeur
        essence = 1;
        Debug.Log("Essence :" + essence);
    }

    public double getEssence() {
        return essence;
    }
    
    public void setEssence(double valeur) {
        essence = valeur;
    }
    
    public bool roule(double consommation) { 
        if (essence == 0)
        {
            stop = true;
            Debug.Log("empty");
        }

        return stop;
    }
}
