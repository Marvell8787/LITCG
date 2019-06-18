using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static class Card_Data{

    private static string[] Card_CType = new string[22];
    private static string[] Card_Picture = new string[22] { "fool", "magician","high-priestess", "empress","emperor", "hierophant", "hermit" , "chariot","death","lovers", "temperance", "hanged-man", "justice" ,"judgement","sun","moon","stars","strength", "fortune-wheel", "tower", "devil", "world" };
    private static string[] Card_Name = new string[22] { "The Fool","The Magician" , "The High PRIESTESS","The EMPRESS","The EMPEROR","The HIEROPHANT", "THE HERMIT", "THE CHARIOT" ,"THE DEATH","THE LOVERS","THE TEMPERANCE", "THE HANGED MAN", "THE JUSTICE" ,"THE JUDGEMENT","The SUN","THE MOON","THE START","STRENGTH", "WHEEL OF FORTUNE","THE TOWER", "THE DEVIL", "THE WORLD" };
    private static string[] Card_Rarity = new string[22];
    private static string[] Card_Description = new string[22];
    private static int[] Card_ATK = new int[22];
    private static string[] Card_Effect = new string[22];

    private static Card_Class[] card_temp = new Card_Class[22];

    public static void Card_Init()
    {
        for(int i = 0; i < 22; i++)
        {
            if (i < 15)
                Card_CType[i] = "Fight";
            else if (i > 14 & i < 19)
                Card_CType[i] = "Magic";
            else if (i >18)
                Card_CType[i] = "Support";
        }

        //宣告 level_temp 陣列並加入資料 Start
        for (int i = 0; i < 22; i++)
        {
            card_temp[i] = new Card_Class(Card_CType[i],Card_Picture[i], Card_Name[i]);
        }

    }

    public static Card_Class Learn_Get(int n)
    {
        return card_temp[n];
    }
}
