using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlidePuzzle16 : MonoBehaviour
{
    [SerializeField] Item.Type clearItem;
    
    public Vector3[] Pos;
    public List<GameObject> PieceList = new List<GameObject>();
    public GameObject CoverLeft;
    public GameObject CoverRight;
    public GameObject PiecesLeft;
    public GameObject PiecesRight;
    public GameObject CoverLeft1;
    public GameObject CoverRight1;
    public GameObject Piece16;
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
           && PieceList[7].transform.localPosition == Pos[7]
           && PieceList[8].transform.localPosition == Pos[8]
           && PieceList[9].transform.localPosition == Pos[9]
           && PieceList[10].transform.localPosition == Pos[10]
           && PieceList[11].transform.localPosition == Pos[11]
           && PieceList[12].transform.localPosition == Pos[12]
           && PieceList[13].transform.localPosition == Pos[13]
           && PieceList[14].transform.localPosition == Pos[14])
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
            Piece16.SetActive(true);
            audioManager.PlaySE(0);
            Invoke("Open",1f);
            Invoke("PlaySE",1f);
            clear = true;
        }
    }
    
    public void Open()
    {
        CoverLeft.SetActive(false);
        CoverRight.SetActive(false);
        PiecesLeft.SetActive(false);
        PiecesRight.SetActive(false);
        CoverLeft1.SetActive(true);
        CoverRight1.SetActive(true);
    }
    
    public void PlaySE()
    {
        audioManager.PlaySE(2);
    }
}
