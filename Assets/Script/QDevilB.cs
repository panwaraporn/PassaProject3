using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QDevilB : MonoBehaviour
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
            gm.InputText.text = ("เมื่อเหม่อมองไปยังรูป ทำให้เกิดผัสสะหรือไม่");
            gm.AText.text = ("เกิดผัสสะ" +
                " (กด A)");
            gm.BText.text = ("ไม่เกิดผัสสะ" +
                " (กด B)");
            if (Input.GetKeyDown("a"))
            {
                gm.points -= 1;
                //player.Damage(1);
            }
            else if (Input.GetKeyDown("b"))
            {
                gm.points += 1;

            }
        }
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (Input.GetKeyDown("a"))
        {
            gm.points -= 1;
        }
        else if (Input.GetKeyDown("b"))
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
            gm.BText.text = (" ");

        }
    }
}
