using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class Exit : MonoBehaviour
{
    public bool exitFlag = false;
    
    public void OnThis()
    {
        if (exitFlag == true)
        {
            Flowchart.BroadcastFungusMessage("ExitOpen");
        }
        else
        {
            Flowchart.BroadcastFungusMessage("ExitClose");
        }
    }
}
