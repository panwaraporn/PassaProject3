﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Angle2 : MonoBehaviour
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
            gm.InputText.text = ("คนดัง");
            gm.InputTextYes.text = ("[Y] เฉย");
            gm.InputTextNo.text = ("[N] ตบๆๆ");
            if (Input.GetKeyDown("y"))
            {
                player.Damage(0);
            }
            else if (Input.GetKeyDown("n"))
            {
                player.Damage(1);
            }
        }
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            if (Input.GetKeyDown("y"))
            {
                player.Damage(2);
            }
            else if (Input.GetKeyDown("n"))
            {
                player.Damage(1);
            }
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            gm.InputText.text = ("55555 ");
            gm.InputTextYes.text = ("6666 ");
            gm.InputTextNo.text = ("1111 ");
        }
    }
}
