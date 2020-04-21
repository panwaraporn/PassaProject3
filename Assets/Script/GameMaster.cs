using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMaster : MonoBehaviour
{


    public int points;
    public Text pointsText;

    public Text InputText;
    public Text AText;
    public Text BText;

    void Start()
    { //ส่วนอัพเดตคะแนนไปในซีนถัดไป
        if (PlayerPrefs.HasKey("Points"))
        {
            if(Application.loadedLevel == 2)
            {
                PlayerPrefs.DeleteKey("Points");
                points = 0;
            }
            else
            {
                points = PlayerPrefs.GetInt("Points");
            }
        }
    }
    void Update()
    {
        pointsText.text = ("คะแนน : " + points);
    }

}
