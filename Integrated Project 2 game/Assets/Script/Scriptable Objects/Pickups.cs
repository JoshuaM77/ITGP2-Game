using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum PickupType
{
    Item,
    Ability
}

public abstract class Pickups : ScriptableObject
{
    public GameObject prefab;
    public PickupType type;
    [TextArea (15,20)]
    public string description;
}
