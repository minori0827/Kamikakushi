using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class NekoAnaBOneBE : MonoBehaviour
{
    public bool BEFlag = false;
    
    public void OnThis()
    {
        if (!BEFlag)
        {
            Flowchart.BroadcastFungusMessage("nekoAnaBE");
        }
        else
        {
            Flowchart.BroadcastFungusMessage("nekoAnaClose");
        }
    }
}
