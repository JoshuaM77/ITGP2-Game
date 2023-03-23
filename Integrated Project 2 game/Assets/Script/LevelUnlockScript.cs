using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class LevelUnlockScript : MonoBehaviour
{

    public bool isUnlocked = false;
    public Scene levelScene;
    public GameObject Row;

    public LevelUnlockScript levelToUnlock1;
    public LevelUnlockScript levelToUnlock2;
    public LevelUnlockScript levelToUnlock3;
    public LevelUnlockScript levelToUnlock4;

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
        levelToUnlock1.LevelUnlock();
        levelToUnlock2.LevelUnlock();
        levelToUnlock3.LevelUnlock();
        levelToUnlock4.LevelUnlock();
        }
    }
    public void lockCurrentRow()
    {
        LevelUnlockScript rowScripts = Row.GetComponentInChildren<LevelUnlockScript>();
        rowScripts.LevelLock();
        if(rowScripts != null)
        {
            rowScripts.LevelLock();
        }
    }
        public void PlayLevel()
    {
        SceneManager.LoadScene(levelScene.name);
    }
}
