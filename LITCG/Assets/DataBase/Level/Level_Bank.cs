using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static class Level_Bank
{
    public static string[] C_Level_Title = new string[7] { "Level-1", "Level-2", "Level-3", "Level-4", "Level-5", "Level-6", "Overall" };
    public static string[] C_Level_QuestionType = new string[7] { "聽力", "聽力", "聽力", "字彙", "字彙", "字彙", "拼字" };
    public static string[] C_Level_Range = new string[7] { "1-10", "11-20", "1-20", "1-10", "11-20", "1-20", "1-20" };

    public static string[] E_Level_Title = new string[7] { "Level-1", "Level-2", "Level-3", "Level-4", "Level-5", "Level-6", "Overall" };
    public static string[] E_Level_QuestionType = new string[7] { "Listening", "Listening", "Listening", "Vocabulary", "Vocabulary", "Vocabulary", "Spelling" };
    public static string[] E_Level_Range = new string[7] { "1-10", "11-20", "1-20", "1-10", "11-20", "1-20", "1-20" };

    //獎
    public static string[] C_Level_Reward_0 = new string[7] { "金幣", "金幣", "金幣、卡牌", "金幣", "金幣", "金幣、卡牌", "金幣、卡牌" };
    public static string[] C_Level_Reward_1 = new string[7] { "無", "無", "無", "無", "無", "無", "無" };
    public static string[] E_Level_Reward_0 = new string[7] { "Money", "Money", "Money", "Money", "Money", "Money", "Money" };
    public static string[] E_Level_Reward_1 = new string[7] { "None", "None", "None", "None", "None", "None", "None" };
    //懲
    public static string[] C_Level_Punishment_0 = new string[7] { "金幣", "金幣", "金幣", "金幣", "金幣", "金幣", "金幣" };
    public static string[] C_Level_Punishment_1 = new string[7] { "無", "無", "無", "無", "無", "無", "無" };
    public static string[] E_Level_Punishment_0 = new string[7] { "Money", "Money", "Money", "Money", "Money", "Money", "Money" };
    public static string[] E_Level_Punishment_1 = new string[7] { "None", "None", "None", "None", "None", "None", "None" };
}
