using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static Inventory Instance;

    public List<InventoryItem> InventoryItems = new List<InventoryItem>();

    public Dictionary<ItemData,InventoryItem> inventoryDictionary = new Dictionary<ItemData, InventoryItem>();


    void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        
    }

    public void addItem(ItemData item)
    {
        if (inventoryDictionary.TryGetValue(item,out InventoryItem value))
        {
            value.addStack();
        }
        else
        {
            InventoryItem newItem = new InventoryItem(item);
            InventoryItems.Add(newItem);
            inventoryDictionary.Add(item,newItem);

        }

    }

    public void removeItem(ItemData item)
    {
        if (inventoryDictionary.TryGetValue(item,out InventoryItem value))
        {
            if (value.stackSize<=1)
            {
                InventoryItems.Remove(value);
                inventoryDictionary.Remove(item);
            }
            else
            {
                value.removeStack();
            }
        }
    }
}
