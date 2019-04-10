using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMaster : MonoBehaviour
{
    public int points;

    public Text pointsText;
    public Text InputText;
    public Text InputTextYes;
    public Text InputTextNo;

    void Update()
    {
        pointsText.text = ("คะแนน: " + points);  
    }
}
