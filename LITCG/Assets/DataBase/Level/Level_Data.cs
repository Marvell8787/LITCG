using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static class Level_Check
{
    public static string s = "";
    public static int choose = 0;
    public static int init = 0;

}
static class Level_Data{

    private static string[] Level_Title = new string[7] { "Level-1", "Level-2", "Level-3", "Level-4", "Level-5", "Level-6", "Overall" };
    private static string[] Level_QuestionType = new string[7] { "Listening", "Translation", "Fill in the blanks", "Listening", "Translation", "Fill in the blanks", "Spelling" };
    private static string[] Level_Range = new string[7] { "1-5", "1-5", "1-5", "6-10", "6-10", "6-10", "1-10" };
    private static string[] Level_Reward = new string[7] { "Money", "Money", "Money", "Money", "Money", "Money", "Money" };
    private static string[] Level_Punishment = new string[7] { "Money", "Money", "Money", "Money", "Money", "Money", "Money" };
    private static string[] Level_HighestScore = new string[7] { "0", "0", "0", "0", "0", "0", "0" };

    private static Level_Class[] level_temp = new Level_Class[7];

    public static void Level_Init()
    {
        //宣告 level_temp 陣列並加入資料 Start
        for (int i = 0; i < 7; i++)
        {
            level_temp[i] = new Level_Class(Level_Title[i], Level_QuestionType[i], Level_Range[i], Level_Reward[i], Level_Punishment[i], Level_HighestScore[i]);
        }
        //宣告 level_temp 陣列並加入資料 End
        Level_Check.init = 1;
        //Debug.Log(learn_temp[2].GetTitle());
    }
    public static Level_Class Level_Get(int n)
    {
        return level_temp[n];
    }
    public static int GetHighestScore(int n)
    {
        return int.Parse(level_temp[n].GetHighestScore());
    }
    public static void ChangeHighestScore(string s,int n)
    {
        level_temp[n].ChangeHighestScore(s);
    }

}
