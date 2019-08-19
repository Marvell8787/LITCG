﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static class System_Data{
    //User
    public static string ID ; // 帳號
    public static string Password ; // 密碼
    public static int language = 0; // 0:中文 1:英文
    public static int Version = 0; // 0:獎懲皆有 1:僅有獎 2:僅有懲 3:獎懲皆無
    //Home 
    private static int Task = 0; 
    private static int Learn = 0;
    private static int Battle = 0;
    private static int Deck = 0;
    private static int Shop = 0;
    private static int Profile = 0;
    private static int GameGoals = 0;
    private static int Status = 0;
    private static int Guide = 0;
    //Task
    private static int Task_Learn = 0;
    private static int Task_Battle = 0;
    //Learn
    private static int Learn_Material = 0;
    private static int Learn_Level = 0;
    private static int Learn_Level_1 = 0;
    private static int Learn_Level_2 = 0;
    private static int Learn_Level_3 = 0;
    private static int Learn_Level_4 = 0;
    private static int Learn_Level_5 = 0;
    private static int Learn_Level_6 = 0;
    private static int Learn_Level_Overall = 0;

    //Battle

    //
    public static void System_Add(string s, int n) // s=想要加的東西  n=數字(可+ -)  
    {
        switch (s)
        {
         //Home   
            case "Task": Task += n; break;
            case "Learn": Learn += n; break;
            case "Battle": Battle += n; break;
            case "Deck": Deck += n; break;
            case "Shop": Shop += n; break;
            case "Profile": Profile += n; break;
            case "GameGoals": GameGoals += n; break;
            case "Status": Status += n; break;
            case "Guide": Guide += n; break;
            //Task
            case "Task_Learn": Task_Learn += n; break;
            case "Task_Battle": Task_Battle += n; break;
            //Learn
            case "Learn_Material": Learn_Material += n; break;
            case "Learn_Level": Learn_Level += n; break;
            case "Learn_Level_1": Learn_Level_1 += n; break;
            case "Learn_Level_2": Learn_Level_2 += n; break;
            case "Learn_Level_3": Learn_Level_3 += n; break;
            case "Learn_Level_4": Learn_Level_4 += n; break;
            case "Learn_Level_5": Learn_Level_5 += n; break;
            case "Learn_Level_6": Learn_Level_6 += n; break;
            case "Learn_Level_Overall": Learn_Level_Overall += n; break;
            //Battle

            //
        }
    }
}
