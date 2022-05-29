using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class StartSetting : MonoBehaviour
{
    public SaveManager saveManager;
    public List<GameObject> itemList = new List<GameObject>();
    public List<Slot> slotList = new List<Slot>();
    public List<DoorNekoAna> doorList = new List<DoorNekoAna>();
    public NekoAnaOneAB nekoAnaOneAB;
    public Mode mode;
    public GameObject talk;
    public AudioManager audioManager;
    public CatCounter catCounter;
    public List<GameObject> cameraList = new List<GameObject>();
    public List<GameObject> lightList = new List<GameObject>();
    public List<GameObject> arrowsList = new List<GameObject>();
    public TurnPuzzle16 turnPuzzle16;
    public SlidePuzzle9 slidePuzzle9;
    public GameObject cScrew1;
    public GameObject cScrew2;
    public GameObject sScrew1;
    public GameObject sScrew2;
    public NekoAnaBoard board;
    public Dial dial1;
    public TreasureBox treasureBox;
    public GameObject tube;
    public Dial dial2;
    public DiscBox discBox1;
    public TurnPuzzle25 turnPuzzle25;
    public SlidePuzzle16 slidePuzzle16;
    public DiscBox2 discBox2;
    public GemBase gemBase;
    public BOneADoor bOneADoor;
    public List<GameObject> yellowPlaceList = new List<GameObject>();
    public List<GameObject> bluePlaceList = new List<GameObject>();
    public List<GameObject> redPlaceList = new List<GameObject>();
    public List<GameObject> whitePlaceList = new List<GameObject>();
    public List<GameObject> blackPlaceList = new List<GameObject>();
    
    void Start()
    {
        SaveData saveData = saveManager.Load();
        
        for (int i = 0; i < itemList.Count; i++)
        {
            if (saveData.itemList[i])
            {
                itemList[i].SetActive(true);
            }
            else
            {
                itemList[i].SetActive(false);
            }
        }
        
        for (int i = 0; i < saveData.haveItemList.Count; i++)
        {
            slotList[i].SetItem(saveData.haveItemList[i]);
        }
        
        for (int i = 0; i < saveData.doorList.Count; i++)
        {
            doorList[i].open = saveData.doorList[i];
        }
        
        nekoAnaOneAB.NekoAnaFlag = saveData.NekoAnaFirst;
        
        mode.mode = saveData.mode;
        
        if (saveData.mode == 2 || saveData.gemBase)
        {
            talk.SetActive(true);
        }
        else
        {
            talk.SetActive(true);
            talk.SetActive(false);
        }
        
        audioManager.PlayBGM(saveData.mode);
        
        catCounter.catCount = saveData.catCount;
        
        cameraList[saveData.loom].SetActive(true);
        lightList[saveData.loom].SetActive(true);
        arrowsList[saveData.loom].SetActive(true);
        
        if (saveData.loom >= 10)
        {
            bOneADoor.DoorOnOff();
        }
        
        if (saveData.turnPuzzle16)
        {
            turnPuzzle16.Open();
        }
        if (saveData.slidePuzzle9)
        {
            slidePuzzle9.Open();
        }
        if (!saveData.cScrew1)
        {
            cScrew1.SetActive(false);
        }
        if (!saveData.cScrew2)
        {
            cScrew2.SetActive(false);
        }
        if (!saveData.sScrew1)
        {
            sScrew1.SetActive(false);
        }
        if (!saveData.sScrew2)
        {
            sScrew2.SetActive(false);
        }
        if (!saveData.cScrew1 && !saveData.cScrew2 && !saveData.sScrew1 && !saveData.sScrew2)
        {
            board.StartSetBoard();
        }
        if (saveData.dial1)
        {
            dial1.Open();
        }
        if (saveData.treasureBox)
        {
            treasureBox.Open();
        }
        if (!saveData.tube)
        {
            tube.SetActive(false);
        }
        if (saveData.dial2)
        {
            dial2.Open();
        }
        if (saveData.discBox1)
        {
            discBox1.SetStart();
        }
        if (saveData.turnPuzzle25)
        {
            turnPuzzle25.Open();
        }
        if (saveData.slidePuzzle16)
        {
            slidePuzzle16.Open();
        }
        if (saveData.discBox2)
        {
            discBox2.SetStart();
        }
        
        for (int i = 0; i < yellowPlaceList.Count; i++)
        {
            if (saveData.yellowPlaceList[i])
            {
                yellowPlaceList[i].SetActive(true);
            }
            else
            {
                yellowPlaceList[i].SetActive(false);
            }
        }
        for (int i = 0; i < bluePlaceList.Count; i++)
        {
            if (saveData.bluePlaceList[i])
            {
                bluePlaceList[i].SetActive(true);
            }
            else
            {
                bluePlaceList[i].SetActive(false);
            }
        }
        for (int i = 0; i < redPlaceList.Count; i++)
        {
            if (saveData.redPlaceList[i])
            {
                redPlaceList[i].SetActive(true);
            }
            else
            {
                redPlaceList[i].SetActive(false);
            }
        }
        for (int i = 0; i < whitePlaceList.Count; i++)
        {
            if (saveData.whitePlaceList[i])
            {
                whitePlaceList[i].SetActive(true);
            }
            else
            {
                whitePlaceList[i].SetActive(false);
            }
        }
        for (int i = 0; i < blackPlaceList.Count; i++)
        {
            if (saveData.blackPlaceList[i])
            {
                blackPlaceList[i].SetActive(true);
            }
            else
            {
                blackPlaceList[i].SetActive(false);
            }
        }
        
        if (saveData.gemBase)
        {
            gemBase.OffCollider();
        }
        
        if (saveData.First)
        {
            Flowchart.BroadcastFungusMessage("First");
        }
    }
}
