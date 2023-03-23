using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelUnlockScript : MonoBehaviour
{

    public bool isUnlocked = false;
    public Scene levelScene;

    public LevelUnlockScript levelToUnlock1;
    public LevelUnlockScript levelToUnlock2;
    public LevelUnlockScript levelToUnlock3;

    // Start is called before the first frame update
    void Start()
    {
        if (isUnlocked == true)

        {
            //Set Level Icon to selectable
        }
    }


    //A function to be Called by the previous level to unlock this one
    public void  LevelUnlock()
    {
        isUnlocked = true;
    }

    //A Function to be called when this level is completed to unlock the next level(s)
    public void UnlockNextLevel()
    {
        levelToUnlock1.LevelUnlock();
        levelToUnlock2.LevelUnlock();
        levelToUnlock3.LevelUnlock();
    }
    public void PlayLevel()
    {
        SceneManager.LoadScene(levelScene.name);
    }
}
