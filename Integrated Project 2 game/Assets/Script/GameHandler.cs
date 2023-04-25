using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.InputSystem;

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
    public GameObject dodgePopup;
    public GameObject p1ItemChoices;
    public GameObject p2ItemChoices;

    public HealthBar p1healthBar;
    public HealthBar p2healthBar;
    public HealthBar enemyHealthBar;
    public Image timerBar;
    public Component timerScale;
    public itemDIsplay[] itemDIsplays;
    private float turnTimer;
    private float timerSize;
    public float turnDuration;
    private float turnTimerScaled;
    private bool isPlayerTurn;
    private int p1Actions;
    private int p2Actions;
    public int playersFinishedTurn;
    public int p1DamageDealt;
    public int p1InitialDamage;
    public int p2DamageDealt;
    public int p2InitialDamage;
    public int p1HealAmount;
    public int p1InitialHeal;
    public int p2HealAmount;
    public int p2InitialHeal;
    public int p1DodgeChance;
    public int p1InitialDodgeChance;
    public int p2DodgeChance;
    public int p2InitialDodgeChance;
    public float p1Defence;
    public float p1InitialDefence;
    public float p2Defence;
    public float p2InitialDefence;
    public int p1initialMaxHealth;
    public int p1MaxHealth;
    public int p2MaxHealth;
    public int p2initialMaxHealth;
    public int healthToRecover;
    public int p1startingHealth;
    public int p2startingHealth;
    public Animation turnAnim;
    public bool p1healSpellSelected;
    public bool p1damageSpellSelected;
    public bool p2healSpellSelected;
    public bool p2damageSpellSelected;



    // Start is called before the first frame update
    void Start()
    {
        p1startingHealth = PlayerPrefs.GetInt("p1startingHealth", 100);
        p2startingHealth = PlayerPrefs.GetInt("p2startingHealth", 100);
        p1healthSystem = new HealthSystem(p1startingHealth);
        p1healthBar.setup(p1healthSystem);
        p2healthSystem = new HealthSystem(p2startingHealth);
        p2healthBar.setup(p2healthSystem);
        enemyHealthSystem = new HealthSystem(100);
        enemyHealthBar.setup(enemyHealthSystem);
        p1Actions = 1;
        p2Actions = 1;
        p1ItemChoices.SetActive(false);
        p2ItemChoices.SetActive(false);
        UpdateStats();
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
            giveItemChoices();
        }
        
    }
    void StartEnemyTurn()
    {
        isPlayerTurn = false;
        turnAnim.Play("Enemy Turn");
        enemyScript.EnemyTurn();
    }
    public void RestartTurn()
    {
        turnTimer = turnDuration;
        p2Actions = 1;
        p1Actions = 1;
        isPlayerTurn = true;
        turnAnim.Play("Player Turn");
        if(StartOfTurn != null)
        {
            StartOfTurn();
        }

    }
    public void p1Damage(int damage)
    {
        
        int dodge = UnityEngine.Random.Range(0,15);
        if(dodge > p1DodgeChance)
        {
        damage = Convert.ToInt32(damage - p1Defence);
        p1healthSystem.Damage(damage);
        }
        else
        {
            Instantiate(dodgePopup, new Vector3(305.09f,-224.82f,-831.73f), Quaternion.identity);
        }
    }
    public void p2Damage(int damage)
    {
        int dodge = UnityEngine.Random.Range(0,15);
        if(dodge > p2DodgeChance)
        {
        damage = Convert.ToInt32(damage - p2Defence);
        p2healthSystem.Damage(damage);
        }
        else
        {
            Instantiate(dodgePopup, new Vector3(333.27f,-224.82f,-831.73f), Quaternion.identity);
        }
    }
    void EndTurn()
    {
        if(EndOfTurn != null)
        {
        EndOfTurn();
        }
        StartEnemyTurn();
    }

    public void giveItemChoices()
    {
        p1ItemChoices.SetActive(true);
        p2ItemChoices.SetActive(true);

    }
    public void UpdateStats()
    {
        Item itemInSlot;
        float p1repeatLoop;
        float p2repeatLoop;
        float p1DamageDealtModifier;
        float p1HealModifier;
        float p1defenceModifier;
        float p1dodgeChanceModifier;
        float p1maxHealthModifier;
        float p2DamageDealtModifier;
        float p2HealModifier;
        float p2defenceModifier;
        float p2dodgeChanceModifier;
        float p2maxHealthModifier;
        p1repeatLoop = 0;
        p2repeatLoop = 0;
        p1DamageDealt = p1InitialDamage;
        p1HealAmount = p1InitialHeal;
        p1DodgeChance = p1InitialDodgeChance;
        p2DamageDealt = p1InitialDamage;
        p2HealAmount = p1InitialHeal;
        p2DodgeChance = p1InitialDodgeChance;
        p1MaxHealth = p1initialMaxHealth;
        p2MaxHealth = p2initialMaxHealth;
        p1healthSystem.setMaxHealth(p1initialMaxHealth);
        p2healthSystem.setMaxHealth(p2initialMaxHealth);
        foreach (itemDIsplay itemDIsplay in itemDIsplays)
        {
            itemDIsplay.AssignItems();
        }
        
        foreach (InventorySlot slot in p1ItemsInventory.Container)
        {
            while (p1repeatLoop < slot.amount)
            {
            itemInSlot = slot.pickup as Item;
            p1DamageDealtModifier = itemInSlot.damageModifier;
            p1HealModifier = itemInSlot.healModifier;
            p1defenceModifier = itemInSlot.defenceModifier;
            p1dodgeChanceModifier = itemInSlot.dodgeChanceModifier;
            p1maxHealthModifier = itemInSlot.maxHealthModifier;
            p1DamageDealt = Convert.ToInt32((float)p1DamageDealt * p1DamageDealtModifier);
            p1HealAmount = Convert.ToInt32((float)p1HealAmount * p1DamageDealtModifier);
            p1Defence = Convert.ToInt32((float)p1Defence * p1defenceModifier);
            p1DodgeChance = Convert.ToInt32((float)p1DodgeChance + p1dodgeChanceModifier);
            p1healthSystem.setMaxHealth(Convert.ToInt32(p1MaxHealth * p1maxHealthModifier));
            p1repeatLoop = p1repeatLoop + 1;
            Debug.Log(p1healthSystem.GetHealth());
            }
        }
        foreach (InventorySlot slot in p2ItemsInventory.Container)
        {
            while (p2repeatLoop < slot.amount)
            {
            itemInSlot = slot.pickup as Item;
            p2DamageDealtModifier = itemInSlot.damageModifier;
            p2HealModifier = itemInSlot.healModifier;
            p2defenceModifier = itemInSlot.defenceModifier;
            p2dodgeChanceModifier = itemInSlot.dodgeChanceModifier;
            p2maxHealthModifier = itemInSlot.maxHealthModifier;
            p2DamageDealt = Convert.ToInt32((float)p2DamageDealt * p2DamageDealtModifier);
            p2HealAmount = Convert.ToInt32((float)p2HealAmount * p2DamageDealtModifier);
            p2Defence = Convert.ToInt32((float)p2Defence * p2defenceModifier);
            p2DodgeChance = Convert.ToInt32((float)p2DodgeChance + p2dodgeChanceModifier);
            p2healthSystem.setMaxHealth(Convert.ToInt32(p2MaxHealth * p2maxHealthModifier));
            p2repeatLoop = p2repeatLoop + 1;
            Debug.Log(p2healthSystem.GetHealth());
            }
        }

    }
    public void savePlayerStats()
    {
        PlayerPrefs.SetInt("p1startingHealth", p1healthSystem.GetHealth());
        PlayerPrefs.SetInt("p2startingHealth", p2healthSystem.GetHealth());
    }

    public void p1SelectHealSpell(InputAction.CallbackContext context)
    {
        if(context.performed)
        {
            p1healSpellSelected = true;
            p1damageSpellSelected = false;
        }
    }
    public void p1SelectDamageSpell(InputAction.CallbackContext context)
    {
        if(context.performed)
        {
            p1healSpellSelected = false;
            p1damageSpellSelected = true;
        }
    }
    public void p1CastSpell()
    {
        if (isPlayerTurn)
        {
            if(p1healSpellSelected && p1Actions > 0)
            {
                p1healthSystem.Heal(p1HealAmount);
                p1Actions = p1Actions -1;
            }
            else if(p1damageSpellSelected && p1Actions > 0)
            {
                enemyHealthSystem.Damage(p1DamageDealt);
                p1Actions = p1Actions -1;
            }
        }
    }
}
