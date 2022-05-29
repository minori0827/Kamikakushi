using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class Talk : MonoBehaviour
{
    public GameObject icon;
    
    public static Talk instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    
    private string talk = "Talk";
    
    public void TalkChange(string newTalk)
    {
        talk = newTalk;
    }
    
    public void OnTalk()
    {
        Flowchart.BroadcastFungusMessage(talk);
        int talkNumber = Random.Range(1,10);
        while (talk == talkNumber.ToString())
        {
            talkNumber = Random.Range(1,10);
        }
        talk = talkNumber.ToString();
    }
    
    public void TalkIconOn()
    {
        icon.SetActive(true);
    }
}
