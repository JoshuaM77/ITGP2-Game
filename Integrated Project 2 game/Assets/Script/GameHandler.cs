using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    HealthSystem healthSystem;


    // Start is called before the first frame update
    void Start()
    {
         healthSystem = new HealthSystem(100);
         Debug.Log("health:" + healthSystem.GetHealth());
    }
    void Update()
    {
        if(Input.GetKeyDown("w"))
        {
            healthSystem.Damage(10);
            Debug.Log("health:" + healthSystem.GetHealth());
        }
        else if (Input.GetKeyDown("s"))
        {
            healthSystem.Heal(10);
            Debug.Log("health:" + healthSystem.GetHealth());
        }
    }

}
