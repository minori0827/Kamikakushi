using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SaveData
{
    public bool First;
    
    public List<bool> itemList = new List<bool>
    {true,true,true,true,true,true,true,true,true,true,true,true,true,true,};
    
    public List<Item> haveItemList = new List<Item>();
    
    public List<bool> doorList = new List<bool>
    {false,false,false,false,false,false,};
    
    public bool NekoAnaFirst;
    
    public int mode;
    
    public int catCount;
    
    public int loom;
    
    public bool turnPuzzle16;
    public bool slidePuzzle9;
    public bool cScrew1;
    public bool cScrew2;
    public bool sScrew1;
    public bool sScrew2;
    public bool dial1;
    public bool treasureBox;
    public bool tube;
    public bool dial2;
    public bool discBox1;
    public bool turnPuzzle25;
    public bool slidePuzzle16;
    public bool discBox2;
    public bool gemBase;
    
    public List<bool> yellowPlaceList = new List<bool>
    {false,false,false,false,false,};
    public List<bool> bluePlaceList = new List<bool>
    {false,false,false,false,false,};
    public List<bool> redPlaceList = new List<bool>
    {false,false,false,false,false,};
    public List<bool> whitePlaceList = new List<bool>
    {false,false,false,false,false,};
    public List<bool> blackPlaceList = new List<bool>
    {false,false,false,false,false,};
}
