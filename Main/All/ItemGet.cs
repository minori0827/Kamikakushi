using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class ItemGet : MonoBehaviour
{
    [SerializeField] Item.Type itemType;
    Item item;
    
    public static ItemGet instance;
    public AudioManager audioManager;
    
    private void Start()
    {
        item = ItemGenerater.instance.Spawn(itemType);
    }
    
    public void GetItem()
    {
        if (ItemBox.instance.BoxCheck())
        {
            ItemBox.instance.SetItem(item);
            gameObject.SetActive(false);
            string talk = itemType.ToString();
            Talk.instance.TalkChange(talk);
            audioManager.PlaySE(3);
        }
        else if (Mode.instance.mode == 1)
        {
            Flowchart.BroadcastFungusMessage("BoxFullNekoda");
        }
        else
        {
            Flowchart.BroadcastFungusMessage("BoxFullOmae");
        }
    }
}
