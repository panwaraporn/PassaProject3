using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    [SerializeField] int level;
    PlayerController player;
    /*private int nextSceneToLoad;
    // Start is called before the first frame update
    void Start()
    {
        nextSceneToLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(nextSceneToLoad);
    }
    // Update is called once per frame
    void Update()
    {
        
    }*/
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            PlayerPrefs.SetInt("PlayerScore", GameMaster.nScore);
            Application.LoadLevel(level);
        }
    }
}
