using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

static class GameGoal_Data{

    //獎懲皆有
    private static string[] C_GameGoal = new string[8] {"","","","","","","","" };
    private static string[] E_GameGoal = new string[8] { "", "", "", "", "", "", "", "" };
    private static string[] C_Item = new string[7] { "", "", "", "", "", "", ""};
    private static string[] E_Item = new string[7] { "", "", "", "", "", "", ""};
    public static void GameGoal_Init()
    {

        switch (System_Data.Version)
        {
            case 0:  //獎懲皆有
                for (int i = 0; i < GameGoal_Bank.C_GameGoal_0.Length; i++)
                    C_GameGoal[i] = GameGoal_Bank.C_GameGoal_0[i];
                for (int i = 0; i < GameGoal_Bank.E_GameGoal_0.Length; i++)
                    E_GameGoal[i] = GameGoal_Bank.E_GameGoal_0[i];
                for (int i = 0; i < GameGoal_Bank.C_Item_0.Length; i++)
                    C_Item[i] = GameGoal_Bank.C_Item_0[i];
                for (int i = 0; i < GameGoal_Bank.E_Item_0.Length; i++)
                    E_Item[i] = GameGoal_Bank.E_Item_0[i];
                break;
            case 1:  //僅有獎
                for (int i = 0; i < GameGoal_Bank.C_GameGoal_1.Length; i++)
                    C_GameGoal[i] = GameGoal_Bank.C_GameGoal_1[i];
                for (int i = 0; i < GameGoal_Bank.E_GameGoal_1.Length; i++)
                    E_GameGoal[i] = GameGoal_Bank.E_GameGoal_1[i];
                for (int i = 0; i < GameGoal_Bank.C_Item_1.Length; i++)
                    C_Item[i] = GameGoal_Bank.C_Item_1[i];
                for (int i = 0; i < GameGoal_Bank.E_Item_1.Length; i++)
                    E_Item[i] = GameGoal_Bank.E_Item_1[i];
                break;
            case 2:  //僅有懲
                for (int i = 0; i < GameGoal_Bank.C_GameGoal_2.Length; i++)
                    C_GameGoal[i] = GameGoal_Bank.C_GameGoal_2[i];
                for (int i = 0; i < GameGoal_Bank.E_GameGoal_2.Length; i++)
                    E_GameGoal[i] = GameGoal_Bank.E_GameGoal_2[i];
                for (int i = 0; i < GameGoal_Bank.C_Item_2.Length; i++)
                    C_Item[i] = GameGoal_Bank.C_Item_2[i];
                for (int i = 0; i < GameGoal_Bank.E_Item_2.Length; i++)
                    E_Item[i] = GameGoal_Bank.E_Item_2[i];
                break;
            case 3:  //獎懲皆無
                for (int i = 0; i < GameGoal_Bank.C_GameGoal_3.Length; i++)
                    C_GameGoal[i] = GameGoal_Bank.C_GameGoal_3[i];
                for (int i = 0; i < GameGoal_Bank.E_GameGoal_3.Length; i++)
                    E_GameGoal[i] = GameGoal_Bank.E_GameGoal_3[i];
                break;
            default:
                for (int i = 0; i < GameGoal_Bank.C_GameGoal_0.Length; i++)
                    C_GameGoal[i] = GameGoal_Bank.C_GameGoal_0[i];
                for (int i = 0; i < GameGoal_Bank.E_GameGoal_0.Length; i++)
                    E_GameGoal[i] = GameGoal_Bank.E_GameGoal_0[i];
                for (int i = 0; i < GameGoal_Bank.C_Item_0.Length; i++)
                    C_Item[i] = GameGoal_Bank.C_Item_0[i];
                for (int i = 0; i < GameGoal_Bank.E_Item_0.Length; i++)
                    E_Item[i] = GameGoal_Bank.E_Item_0[i];
                break;
        }
    }
    public static string GameGoal_Get(int n)
    {
        switch (System_Data.language)
        {
            case 0:
                return C_GameGoal[n];
            case 1:
                return E_GameGoal[n];
            default:
                return C_GameGoal[n];
        }
    }
    public static string Item_Get(int n)
    {
        switch (System_Data.language)
        {
            case 0:
                return C_Item[n];
            case 1:
                return E_Item[n];
            default:
                return C_Item[n];
        }
    }
}
