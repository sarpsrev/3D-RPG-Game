using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class InventoryItem
{
    public ItemData data;
    public int stackSize;

    public InventoryItem(ItemData newData)
    {
        data = newData;
    }

    public void addStack()
    {
        stackSize++;
    }

    public void removeStack()
    {
        stackSize--;
    }
}
