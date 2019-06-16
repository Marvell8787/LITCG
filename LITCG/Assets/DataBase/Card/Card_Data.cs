using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static class Card_Data{

    private static string[] Card_CType = new string[78];
    private static string[] Card_Name = new string[78];
    private static string[] Card_Rarity = new string[78];
    private static string[] Card_Description = new string[78];
    private static int[] Card_ATK = new int[78];
    private static string[] Card_Effect = new string[78];

    private static Card_Class[] card_temp = new Card_Class[78];

    // Use this for initialization
    public static void Card_Init()
    {
        //宣告 level_temp 陣列並加入資料 Start
        for (int i = 0; i < 78; i++)
        {
            card_temp[i] = new Card_Class();
        }

    }
}
