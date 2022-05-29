using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class OneBDoor : DoorNekoAna
{
    public void OnThis()
    {
        if (Mode.instance.mode == 1)
        {
            if (open == false)
            {
                open = true;
                Flowchart.BroadcastFungusMessage("OneBDoorKey");
            }
            else
            {
                Flowchart.BroadcastFungusMessage("DoorNekoda");
            }
        }
        else
        {
            if (open == false)
            {
                Flowchart.BroadcastFungusMessage("OneBDoorClose");
            }
            else
            {
                RoomChange();
            }
        }
    }
}
