using System;
using UnityEngine;

[Serializable]
public class Item
{
    public enum Type
    {
        CrossDriver = 0,
        SingleDriver = 1,
        KeyRed = 2,
        KeyBlue = 3,
        KeyGreen = 4,
        KeyBlack = 5,
        GemYellow = 6,
        GemRed = 7,
        GemBlue = 8,
        GemBlack = 9,
        GemWhite = 10,
        Piece9 = 11,
        Piece16 = 12,
        Pliers = 13
    }
    
    public Type type;     //種類
    public Sprite sprite; //画像
    
    public Item(Type type , Sprite sprite)
    {
        this.type = type;
        this.sprite = sprite;
    }
}
