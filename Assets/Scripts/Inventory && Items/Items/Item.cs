using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : Interactable
{
    public ItemData itemData;
    public override void Interact()
    {
        pickUp();
    }

    public void pickUp()
    {
        Inventory.Instance.addItem(itemData);
        
    }
}
