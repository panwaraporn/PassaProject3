using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMaster : MonoBehaviour
{
    PlayerController player;
    public static int nScore;
    public bool isGameOver = false;

    public Text ScoreText;
    public Text InputText;
    /*public Text InputTextYes;
    public Text InputTextNo;*/

    void Start()
    {
        
        nScore = 0;
        
    }

    void Update()
    {
        
    }

   
}
