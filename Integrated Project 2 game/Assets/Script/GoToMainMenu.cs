using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToMainMenuScript : MonoBehaviour
{
    public void menubutton()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
