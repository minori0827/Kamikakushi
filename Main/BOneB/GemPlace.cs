using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemPlace : MonoBehaviour
{
    [SerializeField] Item.Type YellowGem;
    [SerializeField] Item.Type BlueGem;
    [SerializeField] Item.Type RedGem;
    [SerializeField] Item.Type WhiteGem;
    [SerializeField] Item.Type BlackGem;
    
    public List<GameObject> GemList = new List<GameObject>();
    public GemBase gemBase;
    
    public void OnThis()
    {
        bool Yellow = ItemBox.instance.TryUseItem(YellowGem);
        bool Blue = ItemBox.instance.TryUseItem(BlueGem);
        bool Red = ItemBox.instance.TryUseItem(RedGem);
        bool White = ItemBox.instance.TryUseItem(WhiteGem);
        bool Black = ItemBox.instance.TryUseItem(BlackGem);
        
        if (Yellow == true)
        {
            ItemBox.instance.UsedItem();
            GemList[0].SetActive(true);
        }
        else if (Blue == true)
        {
            ItemBox.instance.UsedItem();
            GemList[1].SetActive(true);
        }
        else if (Red == true)
        {
            ItemBox.instance.UsedItem();
            GemList[2].SetActive(true);
        }
        else if (White == true)
        {
            ItemBox.instance.UsedItem();
            GemList[3].SetActive(true);
        }
        else if (Black == true)
        {
            ItemBox.instance.UsedItem();
            GemList[4].SetActive(true);
        }
        gemBase.ClearCheck();
    }
}
