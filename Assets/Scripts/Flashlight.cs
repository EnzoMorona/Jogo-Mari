using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    public GameObject Light;

    public AudioSource Switch;

    private bool isOn = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if(!isOn)
            {
                LightOn();
                Invoke("LightOn", 0.3f);
            }
            else
            {
                LightOff();
                Invoke("LightOff", 0.3f);
            }
        }
    }


    void LightOn()
    {
        Light.SetActive(true);
        isOn = true;
        Switch.Play();
    }

     void LightOff()
    {
        Light.SetActive(false);
        isOn = false;
        Switch.Play();
    }
}