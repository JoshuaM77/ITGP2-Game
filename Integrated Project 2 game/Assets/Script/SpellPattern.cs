using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SpellPattern : MonoBehaviour
{
    public float deviationScore;
    public bool isDeviating;
    public Collider2D spellCheck1;
    public Collider2D spellCheck2;
    public Collider2D spellCheck3;
    public int currentCheck;
    public TextMeshProUGUI text;

    public GameObject particleObject;

    void Awake()
    {
        currentCheck = 0;
        deviationScore = 0;
    }


    void FixedUpdate()
    {
        if (isDeviating == true)
        {
            deviationScore = deviationScore + Time.deltaTime;
        }

    }

    void OnTriggerEnter2D(Collider2D check)
    {



        if(check.tag == "spellCheck1" )
        {
            currentCheck = 1;
        }
        if(check.tag == "spellCheck2" && currentCheck == 1 )
        {
            currentCheck = 2;
        }
        if(check.tag == "spellCheck3" && currentCheck == 2 )
        {
            currentCheck = 3;
            castSpell();
        }
        else if (check.name == "Pattern Collider" )
        {
            isDeviating = false;
            Debug.Log(isDeviating);
        }
    }
    void OnTriggerExit2D(Collider2D check)
    {
        if (check.name == "Pattern Collider" )
        {
            isDeviating = true;
            Debug.Log(isDeviating);
        }
    }

    void castSpell()
    {
        if (deviationScore > 0.1 && deviationScore < 0.19)
        {
            text.text = ("GOOD");
            text.color = new Color(0.0f, 128.0f,0.0f);
        }
        else if (deviationScore > 0.2 && deviationScore < 0.29)
        {
            text.text = ("AVERAGE");
            text.color = new Color(64.0f, 64.0f,46.0f);
        }
        else if (deviationScore > 0.3)
        {
            text.text = ("POOR");
            text.color = new Color(128.0f, 0.0f,0.0f);
        }
        else
        {
            text.text = ("PERFECT!");
            text.color = new Color(128.0f, 0.0f,128.0f); 
        }
        deviationScore = 0;
        Debug.Log("Spell Cast!");
        
        Instantiate(particleObject);
    }

}
