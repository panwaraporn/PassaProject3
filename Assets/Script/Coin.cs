using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
   /* public int Score;
    public Text ScoreText;*/
    Renderer rend; //ตัวแปลเสียง
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        GameMaster.nScore++;
        Text txt;
        txt = GameObject.Find("/Canvas/ScoreText").GetComponent<Text>();
        txt.text = "Score : " + GameMaster.nScore;
        /*AddScore();*/

        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
        rend.enabled = false;

        Destroy(this.gameObject, audio.clip.length);
       
        /*Destroy(this.gameObject, audio.clip.length);*/
        

    }
   
    /*void AddScore()
    {
        Score++;
        ScoreText.text = ("score : " + Score.ToString());
    }*/

}
