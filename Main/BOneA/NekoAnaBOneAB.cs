using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class NekoAnaBOneAB : MonoBehaviour
{
    public void OnThis()
    {
        if (Mode.instance.mode == 0)
        {
            Flowchart.BroadcastFungusMessage("nekoAnaClose");
        }
        else
        {
            Flowchart.BroadcastFungusMessage("nekoAnaBAB");
        }
    }
}
