using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // Start is called before the first frame update
   
    
    public void Forward()
    {
        if (SceneManager.GetActiveScene().buildIndex < 4)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Back()
    {
        if (SceneManager.GetActiveScene().buildIndex > 0)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

       

    }

    
}
