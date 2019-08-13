using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static class Task_Data{
    private static string[] Learn_Title = new string[7] { "Level-1", "Level-2", "Level-3", "Level-4", "Level-5", "Level-6", "Overall" };
    private static string[] Learn_Threshold = new string[7] { "None", "Level-1's Over", "Level-2's Over", "Level-3's Over", "Level-4's Over", "Level-5's Over", "Level-1~6're Over" };
    private static string[] Learn_Request = new string[7] { "Complete the Level-1(80)！", "Complete the Level-2(80)！", "Complete the Level-3(80)！", "Complete the Level-4(80)！", "Complete the Level-5(80)！", "Complete the Level-6(80)！", "Complete the Overall(80)！" };
    private static string[] Learn_Reward = new string[7] { "Crystal", "Crystal", "Crystal", "Crystal", "Crystal", "Crystal", "Crystal" };
    private static string[] Learn_Punishment = new string[7] { "Crystal", "Crystal", "Crystal", "Crystal", "Crystal", "Crystal", "Crystal" };

    private static string[] Battle_Title = new string[3] { "Battle 1", "Battle 2", "Battle 3" };
    private static string[] Battle_Threshold = new string[3] { "None", "Battle 1's Over", "Battle 2's Over"};
    private static string[] Battle_Request = new string[3] { "Get a win in Battle 1", "Get a win in Battle 2", "Get a win in Battle 3" };
    private static string[] Battle_Reward = new string[3] { "Crystal", "Crystal", "Crystal"};
    private static string[] Battle_Punishment = new string[3] { "Crystal", "Crystal", "Crystal"};

    private static Task_Class[] learn_temp = new Task_Class[7];
    private static Task_Class[] battle_temp = new Task_Class[3];
    public static void Learn_Init()
    {
        //宣告 learn_temp 陣列並加入資料 Start
        
        for(int i = 0; i < 7; i++)
        {
            learn_temp[i] = new Task_Class(Learn_Title[i], Learn_Threshold[i], Learn_Request[i], Learn_Reward[i], Learn_Punishment[i]);
        }
        //宣告 learn_temp 陣列並加入資料 End
        //Debug.Log(learn_temp[2].GetTitle());
    }
    public static Task_Class Learn_Get(int n)
    {
        return learn_temp[n];
    }
    public static void Battle_Init()
    {
        //宣告 battle_temp 陣列並加入資料 Start

        for (int i = 0; i < 3; i++)
        {
            battle_temp[i] = new Task_Class(Battle_Title[i], Battle_Threshold[i], Battle_Request[i], Battle_Reward[i], Battle_Punishment[i]);
        }
        //宣告 battle_temp 陣列並加入資料 End
    }
    public static Task_Class Battle_Get(int n)
    {
        return battle_temp[n];
    }
    public static void ChangeStatus(string s, int c,int n)
    {
        if (s == "learn")
        {
            learn_temp[c].ChangeStatus(n);
        }
        else if (s == "battle")
        {
            battle_temp[c].ChangeStatus(n);
        }
    }
}
