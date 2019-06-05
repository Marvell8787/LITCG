﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static class Learner_Data{
    //Task
    private static int Task_Finish = 0; //完成數量
    private static int Task_Succes = 0; //成功數量
    private static int Task_Fail = 0; //失敗數量
    private static string LearnTask_now = "";  // 目前接了哪個學習任務
    private static string BattleTask_now = ""; // 目前接了哪個對戰任務
    //Learn
    private static int Learn_Finish = 0; //完成數量
    private static int[] Learn_Score = new int[6] { 0,0,0,0,0,0}; //各關上次獲得的分數
    //Battle
    private static int Battle_Num = 0; //對戰次數
    private static int Battle_Win = 0; //勝利次數
    private static int Battle_Lose = 0; //失敗次數
    private static int Battle_Question_Succes_Num = 0; //對戰回答成功次數
    private static int Battle_Question_Fail_Num = 0; //對戰回答失敗次數
    //Reward and Punishment
    private static int Score = 0; //分數
    private static int Coin = 0; //金幣
    private static int Crystal = 0; //水晶
    //Reward
    //Badges
    private static string[] Badges_Name = new string[9] {"", "", "", "", "", "", "", "", "" }; //Task*3 Leaen*3 Battle*3
    private static int[] Badges_Status = new int[9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 }; //Task*3 Leaen*3 Battle*3 Status
    private static int Badges_Num = 0; //獎章數量
    //Card
    private static int Card_Num = 0; //卡片數量
    //Punishment
    private static int Points = 0; //點數
    private static int Mistakes = 0; //失誤

    //Learner_Data Fuction
    public static void Learner_Init()
    {

    }
    public static void Learner_Add(string s,int n) // s=想要加的東西  n=數字(可+ -)   
    {
        switch (s)
        {
            case "Task_Finish":
                Task_Finish+=n;
                break;


        }
    }
}
