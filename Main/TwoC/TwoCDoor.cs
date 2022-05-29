using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class TwoCDoor : DoorNekoAna
{
    [SerializeField] Item.Type clearItem;
    
    public void OnThis()
    {
        if (Mode.instance.mode == 1)
        {
            if (open == true)
            {
                Flowchart.BroadcastFungusMessage("DoorNekoda");
            }
            else
            {
                bool Clear = ItemBox.instance.TryUseItem(clearItem);
                if (Clear == true)
                {
                    Flowchart.BroadcastFungusMessage("TwoCDoorKey");
                    ItemBox.instance.UsedItem();
                    open = true;
                }
                else
                {
                    Flowchart.BroadcastFungusMessage("TwoCDoorCloseInside");
                }
            }
        }
        else
        {
            if (open == false)
            {
                Flowchart.BroadcastFungusMessage("TwoCDoorCloseOutside");
            }
            else
            {
                RoomChange();
            }
        }
    }
}
