﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boxred3 : MonoBehaviour
{
    private GameMaster gm;
    private PlayerController player;

    private void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<GameMaster>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            gm.InputText.text = ("วิชชา คือ ความรู้เท่ากัน");

            gm.AText.text = ("กดปุ่ม Y +1");
            if (Input.GetKeyDown("y"))
            {
                gm.points += 1;
                //player.Damage(1);
            }
        }
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (Input.GetKeyDown("y"))
        {
            gm.points += 1;
        }
    }


    void OnTriggerExit2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            gm.InputText.text = (" ");
            gm.AText.text = (" ");

        }
    }
}