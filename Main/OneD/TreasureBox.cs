using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureBox : MonoBehaviour
{
    [SerializeField] Item.Type clearItem;
    
    public GameObject cover;
    public bool clear;
    public AudioManager audioManager;
    
    public void OnClickObj()
    {
        bool Clear = ItemBox.instance.TryUseItem(clearItem);
        if (Clear == true)
        {
            ItemBox.instance.UsedItem();
            clear = true;
            Invoke("Open",1f);
            Invoke("PlaySE",1f);
            audioManager.PlaySE(0);
        }
    }
    
    public void Open()
    {
        cover.transform.localRotation = Quaternion.Euler(0,0,135);
        this.GetComponent<Collider>().enabled = false;
    }
    
    public void PlaySE()
    {
        audioManager.PlaySE(1);
    }
}
