using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private Text ScoreText; /*ตัวแสดงผลข้อความในหน้า ui */
    private Text ScoreS1;
    public static int score;
    public static int scoreScene1;
    void Start()
    {
        score = 0; /*ตั้งกำหนดเริ่มต้น*/
        ScoreText = GetComponent<Text>(); /*เก็บ component text */
        scoreScene1 = PlayerPrefs.GetInt("scoreScene1", scoreScene1);
    }

    void Update()
    {
        if (scoreScene1 == 1)
        {
            ScoreS1.text = ("scorescoreScene1 : " + scoreScene1);

        }

        ScoreText.text = ("Score : " + score);
        PlayerPrefs.SetInt("Score", score);
    }
}
