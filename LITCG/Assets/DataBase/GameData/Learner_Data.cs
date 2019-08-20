using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static class Learner_Data{
    //Task
    private static int Task_Finish = 0; //完成數量
    private static int Task_Succes = 0; //成功數量
    private static int Task_Fail = 0; //失敗數量
    //Learn
    private static int Learn_Finish = 0; //完成數量
    private static int[] Learn_Score = new int[7] { 0, 0,0,0,0,0,0}; //各關上次獲得的分數
    private static int[] Learn_Score_Request = new int[7] {0, 0, 0, 0, 0, 0, 0 }; //任務要求分數
    //Battle
    private static int Battle_Num = 0; //對戰次數
    private static int Battle_Win = 0; //勝利次數
    private static int Battle_Lose = 0; //失敗次數
    private static int Battle_Question_Succes_Num = 0; //對戰回答成功次數
    private static int Battle_Question_Fail_Num = 0; //對戰回答失敗次數
    //Reward and Punishment
    private static int Score = 100; //分數
    private static int Coin = 100; //金幣
    private static int Crystal = 10; //水晶
    //Reward
    //Badges
    private static string[] Badges_Name = new string[18] {"", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" }; //Task*3 Leaen*3 Battle*3
    private static int[] Badges_Status = new int[18] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }; //獎章持有狀態 0:無 1:有
    private static int Badges_Num = 0; //獎章數量

    //Card
    private static int Cards_Num = 10; //卡片數量
    private static int[] Card_Status = new int[22] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 }; //卡片持有狀態 0:無 1~22:有
    //Punishment
    //Point
    private static string[] Points_Name = new string[3] { "Task", "Learn", "Battle" }; //Task Learn Battle
    private static int[] Points_Status = new int[3] { 3, 3, 3}; //點數持有狀態 Task Learn Battle
    private static int Points_Num = 9; //點數
    //Mistakes
    private static string[] Mistakes_Name = new string[3] { "Warning", "Y Card", "R Card" }; //Task*3 Leaen*3 Battle*3
    private static int[] Mistakes_Status = new int[3] { 0, 0, 0 }; //點數持有狀態 Task Learn Battle
    private static int Mistakes_Num = 0; //失誤

    public static void Learner_Add(string s,int n) // s=想要加的東西  n=數字(可+ -)   
    {
        switch (s)
        {
            //Task
            case "Task_Finish":Task_Finish+=n;break;
            case "Task_Succes":Task_Succes += n;break;
            case "Task_Fail": Task_Fail += n; break;
            //Learn
            case "Learn_Finish": Learn_Finish += n; break;
            //Battle
            case "Battle_Num": Battle_Num += n; break;
            case "Battle_Win": Battle_Win += n; break;
            case "Battle_Lose": Battle_Lose += n; break;
            case "Battle_Question_Succes_Num": Battle_Question_Succes_Num += n; break;
            case "Battle_Question_Fail_Num": Battle_Question_Fail_Num += n; break;
            //Reward and Punishment
            case "Score": Score += n; break;
            case "Coin": Coin += n; break;
            case "Crystal": Crystal += n; break;
            //Reward
            case "Badges_Num": Badges_Num += n; break;
            case "Card_Num": Cards_Num += n; break;
            //Punishment
            case "Points_Num": Points_Num += n; break;
            case "Mistakes_Num": Mistakes_Num += n; break;

            default: break;
        }
    }
    public static int Learner_GetData(string s) // s=想要讀取的東西    
    {
        int n;
        switch (s)
        {
            //Task
            case "Task_Finish": n= Task_Finish; break;
            case "Task_Succes": n= Task_Succes; break;
            case "Task_Fail": n= Task_Fail; break;
            //Learn
            case "Learn_Finish": n= Learn_Finish; break;
            //Battle
            case "Battle_Num":  n= Battle_Num; break;
            case "Battle_Win": n= Battle_Win; break;
            case "Battle_Lose": n= Battle_Lose; break;
            case "Battle_Question_Succes_Num": n= Battle_Question_Succes_Num; break;
            case "Battle_Question_Fail_Num": n= Battle_Question_Fail_Num; break;
            //Reward and Punishment
            case "Score": n= Score; break;
            case "Coin": n= Coin; break;
            case "Crystal": n= Crystal; break;
            //Reward
            case "Badges_Num": n= Badges_Num; break;
            case "Cards_Num": n= Cards_Num; break;
            //Punishment
            case "Points_Num": n= Points_Num; break;
            case "Mistakes_Num": n= Mistakes_Num; break;

            default: n = 0; break;
        }
        return n;
    }
    public static int Learner_GetCard_Status(int n)
    {
            return Card_Status[n];
    }
    public static void Learner_ChangeCard_Status(int n) //Cards
    {
        Card_Status[n] = 1;
    }
    public static void Learner_ChangeBadges_Status(int n) //Badges
    {
        Badges_Status[n] = 1;
    }
    public static void Learner_ChangePoints_Status(int n) //Points
    {
        Points_Status[n] -= 1;
    }
    public static void Learner_ChangeMistakes_Status(int n) //Mistakes
    {
        Mistakes_Status[n] += 1;
    }
}
