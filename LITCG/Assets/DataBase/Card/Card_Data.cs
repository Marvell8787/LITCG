using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static class Card_Data{

    private static string[] Card_CType = new string[7] { "Level-1", "Level-2", "Level-3", "Level-4", "Level-5", "Level-6", "Overall" };
    private static string[] Card_Name = new string[7] { "Listening", "Translation", "Fill in the blanks", "Listening", "Translation", "Fill in the blanks", "Spelling" };
    private static string[] Card_Rarity = new string[7] { "1-5", "1-5", "1-5", "6-10", "6-10", "6-10", "1-10" };
    private static string[] Card_Description = new string[7] { "Money", "Money", "Money", "Money", "Money", "Money", "Money" };
    private static string[] Card_ATK = new string[7] { "Money", "Money", "Money", "Money", "Money", "Money", "Money" };
    private static string[] Card_Effect = new string[7] { "0", "0", "0", "0", "0", "0", "0" };

    private static Card_Class[] card_temp = new Card_Class[7];

    // Use this for initialization
    public static void Level_Init()
    {
        //宣告 level_temp 陣列並加入資料 Start
        for (int i = 0; i < 7; i++)
        {

        }

    }
}
