using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMaster : MonoBehaviour
{

    public static int nScore;
    public bool isGameOver = false;

    public Text ScoreText;
    public Text InputText;
    /*public Text InputTextYes;
    public Text InputTextNo;*/

    void Start()
    {
        nScore = 0;
        
        /*if (PlayerPrefs.HasKey("score"))
        {
            if(Application.loadedLevel == 0)
            {
                PlayerPrefs.DeleteKey("score");
                score = 0;
            }
            else
            {
                score = PlayerPrefs.GetInt("score");
            }
        }*/
    }

    /*public void UpdateScore(int coinValue)
    {
        nScore += coinValue;
        ScoreText.text = "Score : " + nScore.ToString();
    }*/

    void Update()
    {
        /*scoreText.text = ("score : " + score.ToString());*/
        
    }
    /* โค้ดใหม่ แก้ใหม่
    private PlayerController theplayer; 
    private ScoreManager theScoreManager;

    void Start()
    {
        theScoreManager = FindObjectOfType<ScoreManager>();
    }

    void Update()
    {
        
    }

    /*public void RestartGame()
    {
        StartCoroutine("RestartGameCo");
    }

    public IEnumerator RestartGameCo()
    {
        theScoreManager.scoreIncreasing = false;
        theScoreManager.scoreCount = 0;
        theScoreManager.scoreIncreasing = true;
    }*/
   
}
