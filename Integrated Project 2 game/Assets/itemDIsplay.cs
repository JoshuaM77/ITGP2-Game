using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class itemDIsplay : MonoBehaviour
{
    public InventoryObject playerInventory;
    public Item displayItem;
    public Item itemInSlot;
    public TextMeshProUGUI text;
    public Image image;

    void Start()
    {
        AssignItems();
    }
    public void AssignItems()
    {
        foreach (InventorySlot slot in playerInventory.Container)
        {
            itemInSlot = slot.pickup as Item;
            if(itemInSlot.name == displayItem.name)
            {
                text.text = slot.amount.ToString();
                image.sprite = itemInSlot.Icon;
            }
        }
    }

}
