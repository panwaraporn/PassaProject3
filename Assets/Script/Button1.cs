using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button1 : MonoBehaviour
{
    public void BtnStart(string Start)
    {
        SceneManager.LoadScene(Start);
    }

    public void Btnexit()
    {
        Application.Quit();
    }
}
