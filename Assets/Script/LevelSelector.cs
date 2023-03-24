using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    // Start is called before the first frame update
    
    public bool Map1_Level2_1Unlocked;
    public bool Map1_Level2_2Unlocked;
    public bool Map1_Level2_3Unlocked;
    public bool Map1_Level3_1Unlocked;
    public bool Map1_Level3_2Unlocked;
    public bool Map1_Level3_3Unlocked;
    public bool Map1_Level3_4Unlocked;
    public bool Map1_Level3_5Unlocked;
    public bool Map1_Level3_6Unlocked;
    public bool Map1_Level4_1Unlocked;
    public bool Map1_Level4_2Unlocked;
    public bool Map1_Level4_3Unlocked;
    public bool Map1_Level5Unlocked;

    public bool Map2_Level1Unlocked;
    public bool Map2_Level2_1Unlocked;
    public bool Map2_Level2_2Unlocked;
    public bool Map2_Level2_3Unlocked;
    public bool Map2_Level3_1Unlocked;
    public bool Map2_Level3_2Unlocked;
    public bool Map2_Level3_3Unlocked;
    public bool Map2_Level3_4Unlocked;
    public bool Map2_Level3_5Unlocked;
    public bool Map2_Level3_6Unlocked;
    public bool Map2_Level4_1Unlocked;
    public bool Map2_Level4_2Unlocked;
    public bool Map2_Level4_3Unlocked;
    public bool Map2_Level5Unlocked;

    public bool Map3_Level1Unlocked;
    public bool Map3_Level2_1Unlocked;
    public bool Map3_Level2_2Unlocked;
    public bool Map3_Level2_3Unlocked;
    public bool Map3_Level3_1Unlocked;
    public bool Map3_Level3_2Unlocked;
    public bool Map3_Level3_3Unlocked;
    public bool Map3_Level3_4Unlocked;
    public bool Map3_Level3_5Unlocked;
    public bool Map3_Level3_6Unlocked;
    public bool Map3_Level4_1Unlocked;
    public bool Map3_Level4_2Unlocked;
    public bool Map3_Level4_3Unlocked;
    public bool Map3_Level5Unlocked;

    private void Start()
    {
        Map1_Level2_1Unlocked = false;
        Map1_Level2_2Unlocked = false;
        Map1_Level2_3Unlocked = false;
        Map1_Level3_1Unlocked = false;
        Map1_Level3_2Unlocked = false;
        Map1_Level3_3Unlocked = false;
        Map1_Level3_4Unlocked = false;
        Map1_Level3_5Unlocked = false;
        Map1_Level3_6Unlocked = false;
        Map1_Level4_1Unlocked = false;
        Map1_Level4_2Unlocked = false;
        Map1_Level4_3Unlocked = false;
        Map1_Level5Unlocked = false;

        Map2_Level1Unlocked = false;
        Map2_Level2_1Unlocked = false;
        Map2_Level2_2Unlocked = false;
        Map2_Level2_3Unlocked = false;
        Map2_Level3_1Unlocked = false;
        Map2_Level3_2Unlocked = false;
        Map2_Level3_3Unlocked = false;
        Map2_Level3_4Unlocked = false;
        Map2_Level3_5Unlocked = false;
        Map2_Level3_6Unlocked = false;
        Map2_Level4_1Unlocked = false;
        Map2_Level4_2Unlocked = false;
        Map2_Level4_3Unlocked = false;
        Map2_Level5Unlocked = false;

        Map3_Level1Unlocked = false;
        Map3_Level2_1Unlocked = false;
        Map3_Level2_2Unlocked = false;
        Map3_Level2_3Unlocked = false;
        Map3_Level3_1Unlocked = false;
        Map3_Level3_2Unlocked = false;
        Map3_Level3_3Unlocked = false;
        Map3_Level3_4Unlocked = false;
        Map3_Level3_5Unlocked = false;
        Map3_Level3_6Unlocked = false;
        Map3_Level4_1Unlocked = false;
        Map3_Level4_2Unlocked = false;
        Map3_Level4_3Unlocked = false;
        Map3_Level5Unlocked = false;


    }




    public void Map1_Level1()
    {
        SceneManager.LoadScene("Map1_Level1");
    }

    public void Map1_Level2_1()
    {
        
        if (Map1_Level2_1Unlocked == true)
            SceneManager.LoadScene("Map1_Level2.1");
    }

    public void Map1_Level2_2()
    {

        if (Map1_Level2_2Unlocked == true)
            SceneManager.LoadScene("Map1_Level2.2");
    }

    
    public void Map1_Level2_3()
    {

        if (Map1_Level2_3Unlocked == true)
            SceneManager.LoadScene("Map1_Level2.3");
    }

    public void Map1_Level3_1()
    {

        if (Map1_Level3_1Unlocked == true)
            SceneManager.LoadScene("Map1_Level3.1");
    }

    public void Map1_Level3_2()
    {

        if (Map1_Level3_2Unlocked == true)
            SceneManager.LoadScene("Map1_Level3.2");
    }

    public void Map1_Level3_3()
    {

        if (Map1_Level3_3Unlocked == true)
            SceneManager.LoadScene("Map1_Level3.3");
    }

    public void Map1_Level3_4()
    {

        if (Map1_Level3_4Unlocked == true)
            SceneManager.LoadScene("Map1_Level3.4");
    }

    public void Map1_Level3_5()
    {

        if (Map1_Level3_5Unlocked == true)
            SceneManager.LoadScene("Map1_Level3.5");
    }

    public void Map1_Level3_6()
    {

        if (Map1_Level3_6Unlocked == true)
            SceneManager.LoadScene("Map1_Level3.6");
    }

    public void Map1_Level4_1()
    {

        if (Map1_Level4_1Unlocked == true)
            SceneManager.LoadScene("Map1_Level4.1");
    }

    public void Map1_Level4_2()
    {

        if (Map1_Level4_2Unlocked == true)
            SceneManager.LoadScene("Map1_Level4.2");
    }

    public void Map1_Level4_3()
    {

        if (Map1_Level4_3Unlocked == true)
            SceneManager.LoadScene("Map1_Level4.3");
    }

    public void Map1_Level5_1()
    {

        if (Map1_Level5Unlocked == true)
            SceneManager.LoadScene("Map1_Level5");
    }

    
    /// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


    public void Map2_Level1()
    {
        SceneManager.LoadScene("Map2_Level1");
    }

    public void Map2_Level2_1()
    {

        if (Map2_Level2_1Unlocked == true)
            SceneManager.LoadScene("Map2_Level2.1");
    }

    public void Map2_Level2_2()
    {

        if (Map2_Level2_2Unlocked == true)
            SceneManager.LoadScene("Map2_Level2.2");
    }

    public void Map2_Level2_3()
    {

        if (Map2_Level2_3Unlocked == true)
            SceneManager.LoadScene("Map2_Level2.3");
    }

    public void Map2_Level3_1()
    {

        if (Map2_Level3_1Unlocked == true)
            SceneManager.LoadScene("Map2_Level3.1");
    }

    public void Map2_Level3_2()
    {

        if (Map2_Level3_2Unlocked == true)
            SceneManager.LoadScene("Map2_Level3.2");
    }

    public void Map2_Level3_3()
    {

        if (Map2_Level3_3Unlocked == true)
            SceneManager.LoadScene("Map2_Level3.3");
    }

    public void Map2_Level3_4()
    {

        if (Map2_Level3_4Unlocked == true)
            SceneManager.LoadScene("Map2_Level3.4");
    }

    public void Map2_Level3_5()
    {

        if (Map2_Level3_5Unlocked == true)
            SceneManager.LoadScene("Map2_Level3.5");
    }

    public void Map2_Level3_6()
    {

        if (Map2_Level3_6Unlocked == true)
            SceneManager.LoadScene("Map2_Level3.6");
    }

    public void Map2_Level4_1()
    {

        if (Map2_Level4_1Unlocked == true)
            SceneManager.LoadScene("Map2_Level4.1");
    }

    public void Map2_Level4_2()
    {

        if (Map2_Level4_2Unlocked == true)
            SceneManager.LoadScene("Map2_Level4.2");
    }

    public void Map2_Level4_3()
    {

        if (Map2_Level4_3Unlocked == true)
            SceneManager.LoadScene("Map2_Level4.3");
    }

    public void Map2_Level5_1()
    {

        if (Map2_Level5Unlocked == true)
            SceneManager.LoadScene("Map2_Level5");
    }

    /////////////////////////////////////////////////////////////////////////////////////////////////////////

    public void Map3_Level1()
    {
        SceneManager.LoadScene("Map3_Level1");
    }

    public void Map3_Level2_1()
    {

        if (Map3_Level2_1Unlocked == true)
            SceneManager.LoadScene("Map3_Level2.1");
    }

    public void Map3_Level2_2()
    {

        if (Map3_Level2_2Unlocked == true)
            SceneManager.LoadScene("Map3_Level2.2");
    }

    public void Map3_Level2_3()
    {

        if (Map3_Level2_3Unlocked == true)
            SceneManager.LoadScene("Map3_Level2.3");
    }

    public void Map3_Level3_1()
    {

        if (Map3_Level3_1Unlocked == true)
            SceneManager.LoadScene("Map3_Level3.1");
    }

    public void Map3_Level3_2()
    {

        if (Map3_Level3_2Unlocked == true)
            SceneManager.LoadScene("Map3_Level3.2");
    }

    public void Map3_Level3_3()
    {

        if (Map3_Level3_3Unlocked == true)
            SceneManager.LoadScene("Map3_Level3.3");
    }

    public void Map3_Level3_4()
    {

        if (Map3_Level3_4Unlocked == true)
            SceneManager.LoadScene("Map3_Level3.4");
    }

    public void Map3_Level3_5()
    {

        if (Map3_Level3_5Unlocked == true)
            SceneManager.LoadScene("Map3_Level3.5");
    }

    public void Map3_Level3_6()
    {

        if (Map3_Level3_6Unlocked == true)
            SceneManager.LoadScene("Map3_Level3.6");
    }

    public void Map3_Level4_1()
    {

        if (Map3_Level4_1Unlocked == true)
            SceneManager.LoadScene("Map3_Level4.1");
    }

    public void Map3_Level4_2()
    {

        if (Map3_Level4_2Unlocked == true)
            SceneManager.LoadScene("Map3_Level4.2");
    }

    public void Map3_Level4_3()
    {

        if (Map3_Level4_3Unlocked == true)
            SceneManager.LoadScene("Map3_Level4.3");
    }

    public void Map3_Level5_1()
    {

        if (Map3_Level5Unlocked == true)
            SceneManager.LoadScene("Map3_Level5");
    }






}
