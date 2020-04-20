using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorScene1 : MonoBehaviour
{
    /*public int LevelToLoad;*/
    [SerializeField] int level;
    private GameMaster gm;
    PlayerController player;
    private void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<GameMaster>();
        player = FindObjectOfType<PlayerController>();

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            Application.LoadLevel(level);
            /*gm.InputText.text = ("กด E เพื่อเข้าประตู");
            if (Input.GetKeyDown("e"))
            {
                //Application.LoadLevel(ซีนที่จะไป)
                Application.LoadLevel(LevelToLoad);
            }*/
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            gm.InputText.text = (" ");
        }
    }

    /*void SaveScore()
    {
        PlayerPrefs.SetInt("Score", gm.score);
    }*/
}
