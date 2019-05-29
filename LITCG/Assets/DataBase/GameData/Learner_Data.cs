using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static class Learner_Data{
    //Task
    public static int Task_Finish = 0; //完成數量
    public static int Task_Succes = 0; //成功數量
    public static int Task_Fail = 0; //失敗數量
    public static string LearnTask_now = "";  // 目前接了哪個學習任務
    public static string BattleTask_now = ""; // 目前接了哪個對戰任務
    //Learn
    public static int Learn_Finish = 0; //完成數量
    public static int[] Learn_Score = new int[6] { 0,0,0,0,0,0}; //各關上次獲得的分數
    //Battle
    public static int Battle_Num = 0; //對戰次數
    public static int Battle_Win = 0; //勝利次數
    public static int Battle_Lose = 0; //失敗次數
    public static int Battle_Question_Succes_Num = 0; //對戰回答成功次數
    public static int Battle_Question_Fail_Num = 0; //對戰回答失敗次數
    //Reward and Punishment
    public static int Score = 0; //分數
    public static int Coin = 0; //金幣
    public static int Crystal = 0; //水晶
    //Reward
    //Badges
    public static string[] Badges_Name = new string[9] {"", "", "", "", "", "", "", "", "" }; //Task*3 Leaen*3 Battle*3
    public static int[] Badges_Status = new int[9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 }; //Task*3 Leaen*3 Battle*3 Status
    public static int Badges_Num = 0; //獎章數量
    //Card
    public static int Card_Num = 0; //卡片數量
    //Punishment
    public static int Points = 0; //點數
    public static int Mistakes = 0; //失誤
}
