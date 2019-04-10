using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private Text ScoreText;

    public int points;

    void Update()
    {
        ScoreText.text = ("คะแนนรวม: " + points);
    }
}
