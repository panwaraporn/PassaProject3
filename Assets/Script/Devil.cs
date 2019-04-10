using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Devil : MonoBehaviour
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
            gm.InputText.text = ("เจ้าไม่เก่งเลย เอาเปรียบแต่ผู้อื่น เจ้ามันเห็นแก่ตัว");
            gm.InputTextYes.text = ("[Y] เจ้าไม่เก่งเลย");
            gm.InputTextNo.text = ("[N] เจ้ามันเห็นแก่ตัว");
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
            gm.InputText.text = (" ");
            gm.InputTextYes.text = (" ");
            gm.InputTextNo.text = (" ");
        }
    }
}
