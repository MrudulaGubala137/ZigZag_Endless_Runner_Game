using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class GameOverScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Button play;
    public GameObject gameOverPannel;
    public Text scoreDisplay;
    ScoreManagerScript scoreManagerScript;
   
    void Start()
    {
        
        play.onClick.AddListener(Play);
        
        scoreManagerScript = GameObject.Find("ScoreManager").GetComponent<ScoreManagerScript>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void gameOver()
    {
        gameOverPannel.SetActive(true);
        scoreDisplay.text = "Score: " + scoreManagerScript.score;

    }
    public void Play()
    {
        SceneManager.LoadScene(0);
    }
}
