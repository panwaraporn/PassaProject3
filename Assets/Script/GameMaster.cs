using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMaster : MonoBehaviour
{
    public int points;
    public int score;
    public bool isGameOver = false;

    public Text scoreText;
    public Text InputText;
    public Text InputTextYes;
    public Text InputTextNo;

    void Start()
    {
        if (PlayerPrefs.HasKey("คะแนน"))
        {
            if(Application.loadedLevel == 0)
            {
                PlayerPrefs.DeleteKey("คะแนน");
                score = 0;
            }
            else
            {
                    score = PlayerPrefs.GetInt("คะแนน");
            }
        }
    }
     
    void Update()
    {
        scoreText.text = ("คะแนน : " + score.ToString());
        
}

}
