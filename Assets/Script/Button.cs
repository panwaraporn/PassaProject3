using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public void BtnStart(string Story1)
    {
        SceneManager.LoadScene(Story1);
    }
    public void BtnStory1(string Scene1)
    {
        SceneManager.LoadScene(Scene1);
    }
    public void Btnexit()
    {
        Application.Quit();
    }
}
