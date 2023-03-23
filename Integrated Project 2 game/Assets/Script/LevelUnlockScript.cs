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

    // Start is called before the first frame update
    void Start()
    {
        if (isUnlocked == true)

        {
            Image imageRenderer = this.gameObject.GetComponent<Image>();
            imageRenderer.color = Color.green;
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
        }
    }
    //Locks the Current Level
    public void LevelLock()
    {
        isUnlocked = false;
        Image imageRenderer = this.gameObject.GetComponent<Image>();
        imageRenderer.color = Color.gray;
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
        SceneManager.LoadScene(levelScene);
    }
    public void saveUnlocked()
    {
        
    }
}
