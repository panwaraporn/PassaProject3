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
        if (PlayerPrefs.HasKey("Score"))
        {
            if(Application.loadedLevel == 0)
            {
                PlayerPrefs.DeleteKey("Score");
                score = 0;
            }
            else
            {
                    score = PlayerPrefs.GetInt("Score");
            }
        }
    }
     
    void Update()
    {
        scoreText.text = ("Score : " + score.ToString());
        
}

}
