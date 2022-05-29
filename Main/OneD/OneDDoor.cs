using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class OneDDoor : DoorNekoAna
{
    [SerializeField] Item.Type clearItem;
    
    public void OnThis()
    {
        if (open == true)
        {
            RoomChange();
        }
        else
        {
            bool Clear = ItemBox.instance.TryUseItem(clearItem);
            if (Clear == true)
            {
                Flowchart.BroadcastFungusMessage("OneDDoorOpen");
                ItemBox.instance.UsedItem();
                open = true;
            }
            else
            {
                Flowchart.BroadcastFungusMessage("OneDDoorClose");
            }
        }
    }
}
