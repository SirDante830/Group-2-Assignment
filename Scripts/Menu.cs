using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public bool isStart;
    public bool isStartAgain;
    public bool isQuit;

    void OnMouseUp()
    {
        if(isStart)
        {
            Destroy(GameObject.Find("Music"));
            SceneManager.LoadScene("Level");
        }
        if(isStartAgain)
        {
            Destroy(GameObject.Find("Music"));
            SceneManager.LoadScene("MainMenu");
        }
        if (isQuit)
        {
            Application.Quit();
        }
    } 
}