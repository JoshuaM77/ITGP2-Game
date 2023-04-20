using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Pickups/Item")]
public class Item : Pickups
{

    public new string name;
    public Sprite Icon;

    public float damageModifier;
    public float healModifier;
    
    public float critChanceModifier;
    public float critDamageModifier;
    public float turnDurationModifier;
    public float defenceModifier;
    public float dodgeChanceModifier;
    public float maxHealthModifier;
    
    public void Awake()
    {
        type = PickupType.Item;
    }

}
