using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlay : MonoBehaviour
{
    public bool PlayerAlive;
    
    public bool EnemyAlive;

    public int OffenseOrDefense;

    public int Player1Health;

    GameObject Player1Healthbar;

    

    // Start is called before the first frame update
    void Start()
    {
        PlayerAlive = true;
        
        EnemyAlive = true;
        OffenseOrDefense = 0;

        Player1Health = GetComponent<GameObject>(Player1Healthbar);

        
    }

    // Update is called once per frame
    void Update()
    {
        while(PlayerAlive = true  && EnemyAlive == true)
        {
            PlayersTurn();
           
            EnemyTurn();


        }
    }

    public void PlayersTurn()
    {

    }

    

    public void EnemyTurn()
    {

    }

}
