using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Returntomainmenu : MonoBehaviour
{
    public void Exit()
    {
        SceneManager.LoadScene("MainMenu");

    }
}