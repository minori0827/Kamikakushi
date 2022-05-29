using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SaveManager : MonoBehaviour
{
    public bool First;
    public List<GameObject> itemList = new List<GameObject>();
    public List<Slot> slotList = new List<Slot>();
    public List<DoorNekoAna> doorList = new List<DoorNekoAna>();
    public NekoAnaOneAB nekoAnaOneAB;
    public Mode mode;
    public CatCounter catCounter;
    public List<GameObject> cameraList = new List<GameObject>();
    public TurnPuzzle16 turnPuzzle16;
    public SlidePuzzle9 slidePuzzle9;
    public GameObject cScrew1;
    public GameObject cScrew2;
    public GameObject sScrew1;
    public GameObject sScrew2;
    public Dial dial1;
    public TreasureBox treasureBox;
    public GameObject tube;
    public Dial dial2;
    public DiscBox discBox1;
    public TurnPuzzle25 turnPuzzle25;
    public SlidePuzzle16 slidePuzzle16;
    public DiscBox2 discBox2;
    public GemBase gemBase;
    public List<GameObject> yellowPlaceList = new List<GameObject>();
    public List<GameObject> bluePlaceList = new List<GameObject>();
    public List<GameObject> redPlaceList = new List<GameObject>();
    public List<GameObject> whitePlaceList = new List<GameObject>();
    public List<GameObject> blackPlaceList = new List<GameObject>();

    public void Save(SaveData saveData)
    {
        StreamWriter writer;
        
        string jsonstr = JsonUtility.ToJson(saveData);
        
        writer = new StreamWriter(Application.persistentDataPath + "/savedata.json",false);
        writer.Write(jsonstr);
        writer.Flush();
        writer.Close();
    }
    
    public SaveData Load()
    {
        if(File.Exists(Application.persistentDataPath + "/savedata.json"))
        {
            string datastr = "";
            StreamReader reader;
            reader = new StreamReader(Application.persistentDataPath + "/savedata.json");
            datastr = reader.ReadToEnd();
            reader.Close();
            
            return JsonUtility.FromJson<SaveData>(datastr);
        }
        
        SaveData saveData = new SaveData();
        return saveData;
    }
    
    public void PushResetButton()
    {
        SaveData saveData = new SaveData();
        saveData.First = true;
        
        for (int i = 0; i < 14; i++)
        {
            saveData.itemList[i] = true;
        }
        
        saveData.haveItemList = new List<Item>();
        
        for (int i = 0; i < 6; i++)
        {
            saveData.doorList[i] = false;
        }
        
        saveData.NekoAnaFirst = false;
        
        saveData.mode = 0;
        
        saveData.catCount = 0;
        
        saveData.loom = 0;
        
        saveData.turnPuzzle16 = false;
        saveData.slidePuzzle9 = false;
        saveData.cScrew1 = true;
        saveData.cScrew2 = true;
        saveData.sScrew1 = true;
        saveData.sScrew2 = true;
        saveData.dial1 = false;
        saveData.treasureBox = false;
        saveData.tube = true;
        saveData.dial2 = false;
        saveData.discBox1 = false;
        saveData.turnPuzzle25 = false;
        saveData.slidePuzzle16 = false;
        saveData.discBox2 = false;
        saveData.gemBase = false;
        
        for (int i = 0; i < 5; i++)
        {
            saveData.yellowPlaceList[i] = false;
        }
        for (int i = 0; i < 5; i++)
        {
            saveData.bluePlaceList[i] = false;
        }
        for (int i = 0; i < 5; i++)
        {
            saveData.redPlaceList[i] = false;
        }
        for (int i = 0; i < 5; i++)
        {
            saveData.whitePlaceList[i] = false;
        }
        for (int i = 0; i < 5; i++)
        {
            saveData.blackPlaceList[i] = false;
        }
        
        Save(saveData);
    }
    
    public void PushSaveButton()
    {
        SaveData saveData = new SaveData();
        saveData.First = false;
        
        for (int i = 0; i < itemList.Count; i++)
        {
            saveData.itemList[i] = itemList[i].activeSelf;
        }
        
        saveData.haveItemList = new List<Item>();
        
        for (int i = 0; i < slotList.Count; i++)
        {
            if (!slotList[i].IsEmpty())
            {
                saveData.haveItemList.Add(slotList[i].GetItem());
            }
        }
        
        for (int i = 0; i < doorList.Count; i++)
        {
            saveData.doorList[i] = doorList[i].open;
        }
        
        saveData.NekoAnaFirst = nekoAnaOneAB.NekoAnaFlag;
        
        saveData.mode = mode.mode;
        
        saveData.catCount = catCounter.catCount;
        
        for (int i = 0; i < cameraList.Count; i++)
        {
            if (cameraList[i].activeSelf)
            {
                saveData.loom = i;
                break;
            }
        }
        
        saveData.turnPuzzle16 = turnPuzzle16.clear;
        saveData.slidePuzzle9 = slidePuzzle9.clear;
        saveData.cScrew1 = cScrew1.activeSelf;
        saveData.cScrew2 = cScrew2.activeSelf;
        saveData.sScrew1 = sScrew1.activeSelf;
        saveData.sScrew2 = sScrew2.activeSelf;
        saveData.dial1 = dial1.clear;
        saveData.treasureBox = treasureBox.clear;
        saveData.tube = tube.activeSelf;
        saveData.dial2 = dial2.clear;
        saveData.discBox1 = discBox1.clear;
        saveData.turnPuzzle25 = turnPuzzle25.clear;
        saveData.slidePuzzle16 = slidePuzzle16.clear;
        saveData.discBox2 = discBox2.clear;
        saveData.gemBase = gemBase.clear;
        
        for (int i = 0; i < yellowPlaceList.Count; i++)
        {
            saveData.yellowPlaceList[i] = yellowPlaceList[i].activeSelf;
        }
        for (int i = 0; i < bluePlaceList.Count; i++)
        {
            saveData.bluePlaceList[i] = bluePlaceList[i].activeSelf;
        }
        for (int i = 0; i < redPlaceList.Count; i++)
        {
            saveData.redPlaceList[i] = redPlaceList[i].activeSelf;
        }
        for (int i = 0; i < whitePlaceList.Count; i++)
        {
            saveData.whitePlaceList[i] = whitePlaceList[i].activeSelf;
        }
        for (int i = 0; i < blackPlaceList.Count; i++)
        {
            saveData.blackPlaceList[i] = blackPlaceList[i].activeSelf;
        }
        
        Save(saveData);
    }
    
    public void PushLoadButton()
    {
        SaveData saveData = Load();
    }
}
