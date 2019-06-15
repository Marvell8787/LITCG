using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static class Card_Data{

    private static string[] Card_CType = new string[20];
    private static string[] Card_Name = new string[20];
    private static string[] Card_Rarity = new string[7];
    private static string[] Card_Description = new string[20];
    private static int[] Card_ATK = new int[20];
    private static string[] Card_Effect = new string[20];

    private static Card_Class[] card_temp = new Card_Class[20];

    // Use this for initialization
    public static void Card_Init()
    {
        //宣告 level_temp 陣列並加入資料 Start
        for (int i = 0; i < 20; i++)
        {
            card_temp[i] = new Card_Class();
        }

    }
}
