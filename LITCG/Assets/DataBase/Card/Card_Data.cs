using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static class Card_Data{

    private static string[] Card_CType = new string[22];
    private static string[] Card_Picture = new string[22] { "fool", "magician","high-priestess", "empress","emperor", "hierophant", "hermit" , "chariot","death","lovers", "temperance", "hanged-man", "justice" ,"judgement","sun","moon","stars","strength", "fortune-wheel", "tower", "devil", "world" };
    private static string[] Card_Name = new string[22] { "The Fool","The Magician" , "The High PRIESTESS","The EMPRESS","The EMPEROR","The HIEROPHANT", "THE HERMIT", "THE CHARIOT" ,"THE DEATH","THE LOVERS","THE TEMPERANCE", "THE HANGED MAN", "THE JUSTICE" ,"THE JUDGEMENT","The SUN","THE MOON","THE START","STRENGTH", "WHEEL OF FORTUNE","THE TOWER", "THE DEVIL", "THE WORLD" };
    private static string[] Card_Rarity = new string[22] { "N","N","N","N","N","N","N","R", "R", "R","SR", "SR", "SSR", "SSR" ,"R", "R", "R", "SR", "SR", "SR", "SR", "SSR" };
    private static string[] Card_Description = new string[22];
    private static int[] Card_ATK = new int[22] { 1, 1, 1, 2, 2, 2, 2, 3, 3, 3, 4, 4, 5,0,0,0,0,0,0,0,0,0 };
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
        for (int i = 0; i < 22; i++)
        {
            switch (i)
            {
                case 14: Card_Effect[i] = "Player LP + 3"; break;
                case 15: Card_Effect[i] = "Destory 1 Fight Card"; break;
                case 16: Card_Effect[i] = "Enemy LP - 3"; break;
                case 17: Card_Effect[i] = "Draw 2 Card"; break;
                case 18: Card_Effect[i] = "Player LP -10 and Enemy LP -10"; break;
                case 19: Card_Effect[i] = "ALL Fight Card are destory"; break;
                case 20: Card_Effect[i] = "Enemy LP - 5"; break;
                case 21: Card_Effect[i] = "Player LP +5 and Enemy LP -5"; break;
                default: Card_Effect[i] = "#"; break;
            }

        }

        //宣告 level_temp 陣列並加入資料 Start
        for (int i = 0; i < 22; i++)
        {
            card_temp[i] = new Card_Class(Card_CType[i],Card_Picture[i], Card_Name[i], Card_Rarity[i],"", Card_ATK[i], Card_Effect[i]);
        }

    }

    public static Card_Class Learn_Get(int n)
    {
        return card_temp[n];
    }
}
