using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    [SerializeField] int level;
    PlayerController player;

    void Start()
    {
        player = FindObjectOfType<PlayerController>();
    }
    
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            Application.LoadLevel(level);
        }
    }
}
