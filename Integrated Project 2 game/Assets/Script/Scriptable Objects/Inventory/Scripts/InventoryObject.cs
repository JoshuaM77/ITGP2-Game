using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Inventory", menuName = "Pickups/Inventory")]
public class InventoryObject : ScriptableObject
{
    public List<InventorySlot> Container = new List<InventorySlot>();
    public void AddPickup(Pickups _pickup, int _amount)
    {
        bool hasPickup = false;
        for (int i = 0; i <Container.Count; i++)
        {
            if(Container[i].pickup == _pickup)
            {
                Container[i].AddAmount(_amount);
                hasPickup = true;
                break;
            }
        }
        if(!hasPickup)
        {
            Container.Add(new InventorySlot(_pickup, _amount));
        }
    }

}
[System.Serializable]
public class InventorySlot
{
    public Pickups pickup;
    public int amount;
    public int oldAmount = 0;
    public bool isNew;
    public InventorySlot (Pickups _pickup, int _amount)
    {
        pickup = _pickup;
        amount = _amount;
    }
    public void AddAmount(int value)
    {
        amount+= value;
    }
}