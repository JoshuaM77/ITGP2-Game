using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void StartButton()
    {
        SceneManager.LoadScene("MapLocation1");
    }

    public void OptionsButton()
    {
        SceneManager.LoadScene("Options");
    }
    
    public void CreditsButton()
    {
        SceneManager.LoadScene("Credits");
    }

    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("Game Is Exiting");
    }
}
