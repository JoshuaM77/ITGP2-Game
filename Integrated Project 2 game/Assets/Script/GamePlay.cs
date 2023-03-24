using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlay : MonoBehaviour
{
    public bool PlayerAlive;
    
    public bool EnemyAlive;

    public int OffenseOrDefense;

    public int Player1Health;
    public int Player2Health;
    public int EnemyHealth;

    public GameObject Player1Healthbar;

    public bool PlayerHadTurn = false;
    public bool EnemyHadTurn = false;

    public int AttackAmount;
    public int HealAmount;
    
    

    // Start is called before the first frame update
    void Start()
    {
        PlayerAlive = true;
        
        EnemyAlive = true;
        OffenseOrDefense = 0;

        Player1Health = 100;
        Player2Health = 100;
        EnemyHealth = 100;
        AttackAmount = 0;
        HealAmount = 0;

        
    }

    // Update is called once per frame
    void Update()
    {

        
        
        

        if (Player1Health > 0 || Player2Health > 0)
        {
            PlayerAlive = true;
        }
        
        while(PlayerAlive = true  && EnemyAlive == true)
        {
            Debug.Log("Players Turn");
            
            PlayersTurn();

            Debug.Log("Enemies Turn");

            EnemyTurn();


        }
    }

    public void PlayersTurn()
    {
        
        
        PlayerHadTurn = false;

       

    
    }

    

    public void EnemyTurn()
    {
        

        EnemyHadTurn = false;

       
    }

    public void RTPressed()
    {
        AttackAmount = Random.Range(5, 10);
        Debug.Log("Attack amount is " + AttackAmount);
        EnemyHealth = EnemyHealth - AttackAmount;
        Debug.Log("Enemy has been hurt");
        PlayerHadTurn = true;
    }

    public void LTPressed()
    {
        HealAmount = Random.Range(3, 8);
        Player1Health = Player1Health + HealAmount;
        Debug.Log("Player Has Been Healed");
        PlayerHadTurn = true;
    }


}
