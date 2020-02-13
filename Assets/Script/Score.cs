using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private Text ScoreText; /*ตัวแสดงผลข้อความในหน้า ui */
    public static int score;
   /* public static int scoreScene1;*/
    void Start()
    {

        score = 0; /*ตั้งกำหนดเริ่มต้น*/
        ScoreText = GetComponent<Text>(); /*เก็บ component text */
        ScoreText.text = ("คะแนน : 0");
       /* scoreScene1 = PlayerPrefs.GetInt("scoreScene1", scoreScene1);*/

    }

    void Update()
    {
     
        ScoreText.text = ("คะแนน : " + score);

    }

}
