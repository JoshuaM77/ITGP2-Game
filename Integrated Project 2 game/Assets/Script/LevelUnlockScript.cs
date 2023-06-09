using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class LevelUnlockScript : MonoBehaviour
{

    public bool isUnlocked = false;
    public string levelScene;
    public GameObject Row;

    public Component[] buttonsInRow;
    public LevelUnlockScript[] levelsToUnlock;
    public int unlockPref;
    public int levelState = 0;
    public bool firstLevel = false;
    public int levelID;
    public static bool initDone;

    // Start is called before the first frame update
    void Start()
    {

        levelState = PlayerPrefs.GetInt(levelID.ToString() + "LevelState", 0);
        
        if(gameObject.tag == "firstLevel" && levelState == 0)
        {
            isUnlocked = true;
            Image imageRenderer = this.gameObject.GetComponent<Image>();
            imageRenderer.color = Color.green;
        }
        else
        {
            
            if (levelState == 0)

            {
                return;
            }
            else if(levelState == 1)
            {
                LevelUnlock();
            }
            else if (levelState == 2)
            {
                LevelLock();
            }
        }
    }


    //A function to be Called by the previous level to unlock this one
    public void  LevelUnlock()
    {
        if(isUnlocked == false)
        {
            isUnlocked = true;
            Image imageRenderer = this.gameObject.GetComponent<Image>();
            imageRenderer.color = Color.green;
            levelState = 1;
            saveUnlocked();
        }
    }
    //Locks the Current Level
    public void LevelLock()
    {
        isUnlocked = false;
        Image imageRenderer = this.gameObject.GetComponent<Image>();
        imageRenderer.color = Color.gray;
        levelState = 2;
        saveUnlocked();
    }

    //A Function to be called when this level is completed to unlock the next level(s)
    public void UnlockNextLevel()
    {
        if(isUnlocked)
        {
        lockCurrentRow();
        LevelLock();
        foreach (LevelUnlockScript levelToUnlock in levelsToUnlock)
            levelToUnlock.LevelUnlock();
        }
    }
    //Lock the Row that this button is on
    public void lockCurrentRow()
    {
     buttonsInRow = Row.GetComponentsInChildren<LevelUnlockScript>();
    
    foreach (LevelUnlockScript script in buttonsInRow)
            script.LevelLock();
    }
    public void PlayLevel()
    {
        MapSceneEnd();
        SceneManager.LoadScene(levelScene);
    }
    public void saveUnlocked()
    {
        PlayerPrefs.SetInt(levelID.ToString() + "LevelState", levelState);
    }
    private void MapSceneEnd()
    {
        Debug.Log(PlayerPrefs.GetInt(levelID.ToString() + "LevelState")) ;
        saveUnlocked();
    }
    int boolToInt(bool val)
    {
        if (val)
            return 1;
        else
            return 0;
    }

    bool intToBool(int val)
    {
        if (val != 0)
            return true;
        else
            return false;

    }
}
