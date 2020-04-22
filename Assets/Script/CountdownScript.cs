using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownScript : MonoBehaviour
{
    public static float timeLeft = 30f;
    Text showTime;
    Canvas gameOver;
    // Start is called before the first frame update
    void Start()
    {
        showTime = GameObject.Find("/Canvas/TextShowTime").GetComponent<Text>();
        gameOver = GameObject.Find("/Canvas/Canvas").GetComponent<Canvas>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            showTime.text = timeLeft.ToString("นับถอยหลัง ###0");
        }else
        {
            gameOver.enabled = true;
        }
    }
}
