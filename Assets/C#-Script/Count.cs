using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Count : MonoBehaviour
{
  int score = 0;
    public Text scoreText;

    public void AddScore()
    {
        score++;
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
     scoreText.text = "SCORE: " + score.ToString();
     
    }
}
