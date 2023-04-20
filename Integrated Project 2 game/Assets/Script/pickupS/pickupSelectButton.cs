using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupSelectButton : MonoBehaviour
{
    public InventoryObject playerInventory;
    public ItemCard itemCard;
    private Item itemToGive;
    public GameObject cardChoiceParent;

public void GiveItem()
{
    itemToGive = itemCard.item;
    playerInventory.AddPickup(itemToGive,1);
    cardChoiceParent.SetActive(false);
}
}
