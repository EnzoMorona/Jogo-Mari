using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Paginas : MonoBehaviour
{
    public Pontos score;

    public GameObject collectText;

    public AudioSource collectSound;

    private GameObject page;

    private bool inReach;
    


    void Start()
    {

        collectText.SetActive(false);


        inReach = false;

        page = this.gameObject;
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = true;
            collectText.SetActive(true);
        }
        
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            collectText.SetActive(false);
            inReach = false;
        }
    }

    void Update()
    {

        if (inReach && Input.GetButtonDown("pegar"))
        {
            collectSound.Play();
            collectText.SetActive(false);
            page.SetActive(false);
            score.AddScore(1);
            inReach = false;
        }
    }
}

