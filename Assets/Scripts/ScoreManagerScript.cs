using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManagerScript : MonoBehaviour
{
    // Start is called before the first frame update
    int score;
    public Text scoreText;
    public void Score(int value)
    {
        score = score + value;
        scoreText.text = score.ToString();
        Debug.Log(score);

    }

    // Update is called once per frame
    void Update()
    {

        
    }
   
}
