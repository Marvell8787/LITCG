using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static class Card_Data{

    private static string[] Card_CType = new string[30];
    private static string[] Card_Name = new string[30];
    private static string[] Card_Rarity = new string[30];
    private static string[] Card_Description = new string[30];
    private static int[] Card_ATK = new int[30];
    private static string[] Card_Effect = new string[30];

    private static Card_Class[] card_temp = new Card_Class[30];

    // Use this for initialization
    public static void Card_Init()
    {
        for(int i = 0; i < 30; i++)
        {
            if (i < 18)
                Card_CType[i] = "Fight";
            else if (i > 17 & i < 24)
                Card_CType[i] = "Magic";
            else if (i >23)
                Card_CType[i] = "Support";
        }

        //宣告 level_temp 陣列並加入資料 Start
        for (int i = 0; i < 30; i++)
        {
            card_temp[i] = new Card_Class();
        }

    }
}
