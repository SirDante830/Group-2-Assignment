using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //public GameObject AudioManager;
    public void KillMusic()
    {
        Destroy(GameObject.Find("Music"));
        PlayButton();
    }

    public void PlayButton()
    {
        SceneManager.LoadScene("Level");
    }

    public void CreditScene()
    {
        SceneManager.LoadScene("CreditScene");
    }

    public void BackScene()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}