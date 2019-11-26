using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private Text ScoreText; /*ตัวแสดงผลข้อความในหน้า ui */
   /* private Text ScoreS1;*/
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
     
        ScoreText.text = ("Score : " + score);
        /*if (scoreScene1 > 0)
        {
            ScoreS1.text = ("scoreScene1 : " + score);

        }*/

    }
    public int GetScore()
    {
        return score;
    }

}
