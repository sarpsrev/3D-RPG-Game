using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : Interactable
{
    public ItemData itemData;
    // all ıtems script related this function
    public override void Interact()
    {
        pickUp();
    }

    public void pickUp()
    {
        Inventory.Instance.addItem(itemData);
        Destroy(gameObject,0.5f);
        
    }
}
