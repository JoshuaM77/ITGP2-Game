using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class GameHandler : MonoBehaviour
{
    HealthSystem p1healthSystem;
    HealthSystem p2healthSystem;
    HealthSystem enemyHealthSystem;

    public delegate void PartOfTurn();
    public static event PartOfTurn StartOfTurn;
    public  static event PartOfTurn EndOfTurn;
    public EnemyScript enemyScript;
    public InventoryObject p1ItemsInventory;
    public InventoryObject p2ItemsInventory;

    public HealthBar p1healthBar;
    public HealthBar p2healthBar;
    public HealthBar enemyHealthBar;
    public Image timerBar;
    public Component timerScale;
    private float turnTimer;
    private float timerSize;
    public float turnDuration;
    private float turnTimerScaled;
    private bool isPlayerTurn;
    private int p1Actions;
    private int p2Actions;
    public int playersFinishedTurn;
    public int p1DamageDealt;
    public int p2DamageDealt;
    public int p1HealAmount;
    public int p2HealAmount;
    public int p1DodgeChance;
    public int p2DodgeChance;
    public float p1Defence;
    public float p2Defence;


    // Start is called before the first frame update
    void Start()
    {
         
        p1healthSystem = new HealthSystem(100);
        p1healthBar.setup(p1healthSystem);
        p2healthSystem = new HealthSystem(100);
        p2healthBar.setup(p2healthSystem);
        enemyHealthSystem = new HealthSystem(100);
        enemyHealthBar.setup(enemyHealthSystem);
        p1Actions = 1;
        p2Actions = 1;
        RestartTurn();
    }
    void Update()
    {
        timerSize = 20;
        turnTimerScaled = turnTimer*timerSize;
        timerBar.rectTransform.sizeDelta = new Vector2(turnTimerScaled, 100.0f);
        if(turnTimer > 0 && isPlayerTurn)
        {
            turnTimer = turnTimer - Time.deltaTime;
        }
        else if (turnTimer < 0 && isPlayerTurn)
        {
            turnTimer = 0;
            EndTurn();
        }

        if(isPlayerTurn)
        {
        if(Input.GetKeyDown("w") && p1Actions > 0)
        {
            enemyHealthSystem.Damage(p1DamageDealt);
            p1Actions = p1Actions -1;
        }
        else if (Input.GetKeyDown("s") && p1Actions > 0)
        {
            p1healthSystem.Heal(p1HealAmount);
            p1Actions = p1Actions -1;
        }
        else if(Input.GetKeyDown("o") && p2Actions > 0)
        {
            enemyHealthSystem.Damage(p2DamageDealt);
            p2Actions = p2Actions -1;
        }
        else if (Input.GetKeyDown("l") && p2Actions > 0)
        {
            p2healthSystem.Heal(p1HealAmount);
            p2Actions = p2Actions -1;
        }
        }
        
        if(enemyHealthSystem.GetHealth() <= 0)
        {
            enemyHealthSystem.Heal(100);
        }
        
    }
    void StartEnemyTurn()
    {
        isPlayerTurn = false;
        enemyScript.EnemyTurn();
    }
    public void RestartTurn()
    {
        turnTimer = turnDuration;
        p2Actions = 1;
        p1Actions = 1;
        isPlayerTurn = true;
        if(StartOfTurn != null)
        {
            StartOfTurn();
        }

    }
    public void p1Damage(int damage)
    {
        
        int dodge = UnityEngine.Random.Range(0,10);
        damage = Convert.ToInt32(damage - p1Defence);
        p1healthSystem.Damage(damage);
    }
    public void p2Damage(int damage)
    {
        float damagePercent = 2;
        damagePercent = damagePercent - p2Defence;
        damage = Convert.ToInt32(damage*damagePercent);
        p2healthSystem.Damage(damage);
    }
    void EndTurn()
    {
        if(EndOfTurn != null)
        {
        EndOfTurn();
        }
        StartEnemyTurn();
    }
    public void UpdateStats()
    {
        Item itemInSlot;
        float p1DamageDealtModifier;
        float p1HealModifier;
        float p1defenceModifier;
        float p1dodgeChanceModifier;
        float p1maxHealthModifier;
        foreach (InventorySlot slot in p1ItemsInventory.Container)
        {

            if (slot.amount > slot.oldAmount)
            {
            itemInSlot = slot.pickup as Item;
            p1DamageDealtModifier = itemInSlot.damageModifier;
            p1HealModifier = itemInSlot.healModifier;
            p1defenceModifier = itemInSlot.defenceModifier;
            p1dodgeChanceModifier = itemInSlot.dodgeChanceModifier;
            p1maxHealthModifier = itemInSlot.maxHealthModifier;
            p1DamageDealt = Convert.ToInt32((float)p1DamageDealt * p1DamageDealtModifier);
            p1HealAmount = Convert.ToInt32((float)p1HealAmount * p1DamageDealtModifier);
            slot.oldAmount = slot.amount;
            }
            else if (slot.isNew)
            {
            itemInSlot = slot.pickup as Item;
            p1DamageDealtModifier = itemInSlot.damageModifier;
            p1HealModifier = itemInSlot.healModifier;
            p1defenceModifier = itemInSlot.defenceModifier;
            p1dodgeChanceModifier = itemInSlot.dodgeChanceModifier;
            p1maxHealthModifier = itemInSlot.maxHealthModifier;
            p1DamageDealt = Convert.ToInt32((float)p1DamageDealt * p1DamageDealtModifier);
            p1HealAmount = Convert.ToInt32((float)p1HealAmount * p1DamageDealtModifier);
            slot.isNew = false;
            }
            
        }
    }


}
