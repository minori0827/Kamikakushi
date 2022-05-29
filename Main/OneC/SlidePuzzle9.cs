using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlidePuzzle9 : MonoBehaviour
{
    [SerializeField] Item.Type clearItem;
    
    public Vector3[] Pos;
    public List<GameObject> PieceList = new List<GameObject>();
    public GameObject Pieces;
    public GameObject Piece9;
    public GameObject Cover0;
    public GameObject Cover1;
    public bool clear;
    public AudioManager audioManager;
    
    public void ClearCheck()
    {
        if(PieceList[0].transform.localPosition == Pos[0]
           && PieceList[1].transform.localPosition == Pos[1]
           && PieceList[2].transform.localPosition == Pos[2]
           && PieceList[3].transform.localPosition == Pos[3]
           && PieceList[4].transform.localPosition == Pos[4]
           && PieceList[5].transform.localPosition == Pos[5]
           && PieceList[6].transform.localPosition == Pos[6]
           && PieceList[7].transform.localPosition == Pos[7])
        {
            this.GetComponent<Collider>().enabled = true;
        }
    }
    
    public void OnClickObj()
    {
        bool Clear = ItemBox.instance.TryUseItem(clearItem) && this.GetComponent<Collider>().enabled == true;
        if (Clear == true)
        {
            ItemBox.instance.UsedItem();
            Piece9.SetActive(true);
            clear = true;
            Invoke("Open",1f);
            Invoke("PlaySE",1f);
            audioManager.PlaySE(0);
        }
    }
    
    public void Open()
    {
        Pieces.SetActive(false);
        Cover0.SetActive(false);
        Cover1.SetActive(true);
    }
    
    public void PlaySE()
    {
        audioManager.PlaySE(1);
    }
}
