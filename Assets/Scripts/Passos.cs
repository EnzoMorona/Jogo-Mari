using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Passos : MonoBehaviour
{
    public AudioSource Andando, Correndo;

    void Update()
    {
         if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A)
         || Input.GetKey(KeyCode.S))
         {
            if  (Input.GetKey(KeyCode.LeftShift))
            {
                Andando.enabled = false;
                Correndo.enabled = true;
            }
            else
            {
                Andando.enabled = true;
                Correndo.enabled = false;   
            }
         }
         else
         {
                Andando.enabled = false;
                Correndo.enabled = false;  
         }
        
    }
}
