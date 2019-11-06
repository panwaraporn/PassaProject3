using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMasterScene2 : MonoBehaviour
{
    public int points;

    public int score;

    public Text pointsText;
    public Text InputText;
    public Text InputTextYes;
    public Text InputTextNo;

    void Start()
    {
        if (PlayerPrefs.HasKey("Score"))
        {
            if (Application.loadedLevel == 0)
            {
                PlayerPrefs.DeleteKey("Score");
               /* score = 0;*/
            }
            else
            {
                score = PlayerPrefs.GetInt("Score");
            }
        }
    }

    void Update()
    {
        pointsText.text = ("คะแนน: " + points.ToString());
    }
}
