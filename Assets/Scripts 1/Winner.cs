using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Winner : MonoBehaviour
{
    int position=0;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Racer")
        {
            position++;
            other.GetComponent<Car>().position=position;
            other.GetComponent<Car>().hasFinishedRace=true;    
        }
        
    }
}
