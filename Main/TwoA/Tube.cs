using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tube : MonoBehaviour
{
    [SerializeField] Item.Type clearItem;
    public bool clear;
    public AudioManager audioManager;
    
    public void OnClickObj()
    {
        bool Clear = ItemBox.instance.TryUseItem(clearItem);
        if (Clear == true)
        {
            ItemBox.instance.UsedItem();
            gameObject.SetActive(false);
            clear = true;
        }
    }
    
    public void PlaySE()
    {
        audioManager.PlaySE(0);
    }
}
