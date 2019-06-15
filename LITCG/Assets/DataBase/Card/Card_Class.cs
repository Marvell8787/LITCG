using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Card_Class{
    private string CType = ""; //戰鬥卡 魔法卡 支援卡
    private string Name = ""; //名字
    private string Rarity = ""; //稀有度 N R SR SSR
    private string Description = ""; //描述
    private int ATK = 0; //戰鬥卡
    private string Effect = ""; //魔法卡 支援卡

    public Card_Class(string _CType = "", string _Name = "", string _Rarity = "", string _Description = "", int _ATK = 0, string _Effect = "")
    {
        CType = _CType;
        Name = _Name;
        Rarity = _Rarity;
        Description = _Description;
        ATK = _ATK;
        Effect = _Effect;
    }
    public string GetCType()
    {
        return CType;
    }
    public string GetName()
    {
        return Name;
    }
    public string GetRarity()
    {
        return Rarity;
    }
    public string GetDescription()
    {
        return Description;
    }
    public int GetATK()
    {
        return ATK;
    }
    public string GetEffect()
    {
        return Effect;
    }
}
