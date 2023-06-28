using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Mob")
        {
            SceneManager.LoadScene("Death");
        }

        if (other.gameObject.tag == "Car")
        {
            SceneManager.LoadScene("Victory");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
