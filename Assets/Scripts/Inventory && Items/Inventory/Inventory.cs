using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static Inventory Instance;

    public List<InventoryItem> InventoryItems = new List<InventoryItem>();

    public Dictionary<ItemData,InventoryItem> inventoryDictionary = new Dictionary<ItemData, InventoryItem>();

    public Transform inventorySlot;
    public Item_UI[] itemSlot;


    void Start()
    {
        itemSlot = inventorySlot.GetComponentsInChildren<Item_UI>();
    }


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
        updateInventoryUI();

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
            updateInventoryUI();
        }
    }

    void updateInventoryUI()
    {
        for (int i = 0; i < InventoryItems.Count; i++)
        {
            itemSlot[i].updateSlotUI(InventoryItems[i]);
        }
    }
}
