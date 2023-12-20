using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item_UI : MonoBehaviour
{
    public Image itemImage;
    public Text itemAmountText;

    public InventoryItem item; 

    public void updateSlotUI(InventoryItem newItem)
    {
        item = newItem;
        if (item !=null)
        {
            itemImage.sprite = item.data.ItemIcon;

            if (item.stackSize>1)
            {
                itemAmountText.text = item.stackSize.ToString();
            }
            else
            {
                itemAmountText.text = "";
            }
        }
    }

}
