using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : Interactable
{
    public override void Interact()
    {
        pickUp();
    }

    public void pickUp()
    {
        Destroy(gameObject);
    }
}
