using UnityEngine;
using System.Collections.Generic;

public class Inventory : MonoBehaviour
{
    public Dictionary<ItemSO, int> items = new Dictionary<ItemSO, int>();
    public int maxSlots = 50;

    public delegate void OnInventoryChanged();
    public event OnInventoryChanged onInventoryUpdated;

    public void AddItem(ItemSO newItem, int amount)
    {
        if (items.ContainsKey(newItem))
        {
            items[newItem] += amount;
        }
        else
        {
            if (items.Count >= maxSlots)
            {
                Debug.Log("Inventory full!");
                return;
            }
            items.Add(newItem, amount);
        }
        //update inventory UI Here
        onInventoryUpdated?.Invoke();
    }

    public void RemoveItem(ItemSO itemToRemove, int amount)
    {
        if (items.ContainsKey(itemToRemove))
        {
            items[itemToRemove] -= amount;
            if (items[itemToRemove] <= 0)
            {
                items.Remove(itemToRemove);
            }
            //update inventory UI Here
            onInventoryUpdated?.Invoke();
        }
    }

    public bool HasItem(ItemSO item, int amount)
    {
        return items.ContainsKey(item) && items[item] >= amount;
    }
}
