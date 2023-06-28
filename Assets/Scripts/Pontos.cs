using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Pontos : MonoBehaviour
{
    public Text ScoreText;
    public int score = 0;
    public int maxScore;
    public GameObject Carro;

    void Start()
    {
        score = 0;
        Carro.SetActive(false);   
    }

    public void AddScore(int newScore)
    {
        score += newScore; 
    }

    public void UpdateScore()
    {
        ScoreText.text = "Paginas pegas: "+score;

        if(score == maxScore)
        {
            ScoreText.text = "CORRA PARA SAIDA";
            Carro.SetActive(true); 
        }
    }



    void Update()
    {
        UpdateScore();
    }
}


