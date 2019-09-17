using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Canvas_Settlement_Battle : MonoBehaviour {
    // Use this for initialization
    void Start () {
        Button b_temp;
        Text t_temp;

        switch (System_Data.language)
        {
            case 0:
                b_temp = GameObject.Find("Button_Back").GetComponent<Button>();
                b_temp.GetComponentInChildren<Text>().text = "返回";
                t_temp = GameObject.Find("Text_QNum").GetComponent<Text>();
                t_temp.text = "題號";
                t_temp = GameObject.Find("Text_Question").GetComponent<Text>();
                t_temp.text = "問題";
                t_temp = GameObject.Find("Text_Answer").GetComponent<Text>();
                t_temp.text = "答案";
                t_temp = GameObject.Find("Text_Choose").GetComponent<Text>();
                t_temp.text = "選擇";
                t_temp = GameObject.Find("Text_Feedback").GetComponent<Text>();
                t_temp.text = "結果";
                t_temp = GameObject.Find("Text_Crystal").GetComponent<Text>();
                t_temp.text = "水晶：";
                t_temp = GameObject.Find("Text_Flag").GetComponent<Text>();
                if (BattleCheck.Flag == 0)
                    t_temp.text = "失敗 !";
                else
                    t_temp.text = "勝利 !";
                break;
            case 1:
                t_temp = GameObject.Find("Text_Flag").GetComponent<Text>();
                if (BattleCheck.Flag == 0)
                    t_temp.text = "Lose !";
                else
                    t_temp.text = "Win !";
                break;
            default:
                break;
        }

        if(BQuestion_Check.Question_Num < 6)
            Settlement_BattleCheck.PageDown = 1;
        else if(BQuestion_Check.Question_Num < 11)
            Settlement_BattleCheck.PageDown = 2;
        else if(BQuestion_Check.Question_Num < 16)
            Settlement_BattleCheck.PageDown = 3;
        else
            Settlement_BattleCheck.PageDown = 4;

        Settlement_BattleCheck.Page = 0;
        Settlement_BattleCheck.PageUP = 1;


        t_temp = GameObject.Find("Text_PageUp").GetComponent<Text>();
        t_temp.text = Settlement_BattleCheck.PageUP.ToString();
        t_temp = GameObject.Find("Text_PageDown").GetComponent<Text>();
        t_temp.text = Settlement_BattleCheck.PageDown.ToString();


        for (int i = 0; i < 5; i++)
        {
            t_temp = GameObject.Find("Text_QNum_" + (i + 1).ToString()).GetComponent<Text>();
            t_temp.text = "";
            t_temp = GameObject.Find("Text_Question_" + (i + 1).ToString()).GetComponent<Text>();
            t_temp.text = "";
            t_temp = GameObject.Find("Text_Answer_" + (i + 1).ToString()).GetComponent<Text>();
            t_temp.text = "";
            t_temp = GameObject.Find("Text_Choose_" + (i + 1).ToString()).GetComponent<Text>();
            t_temp.text = "";
            t_temp = GameObject.Find("Text_Feedback_" + (i + 1).ToString()).GetComponent<Text>();
            t_temp.text = "";
        }

        ShowContent();

        //獎懲
        switch (Enemy.No)
        {
            case 0:
                if (BattleCheck.Flag == 1) //成功
                {
                    t_temp = GameObject.Find("Text_Crystal_n").GetComponent<Text>();
                    t_temp.text = Learner_Data.Learner_GetData("Crystal").ToString() + " -> ";
                    switch (System_Data.Version)
                    {
                        case 0:
                        case 1:
                            Learner_Data.Learner_Add("Crystal", 10);
                            break;
                        default:
                            break;
                    }
                    t_temp.text = t_temp.text + Learner_Data.Learner_GetData("Crystal").ToString();
                }
                else //失敗
                {
                    t_temp = GameObject.Find("Text_Crystal_n").GetComponent<Text>();
                    t_temp.text = Learner_Data.Learner_GetData("Crystal").ToString() + " -> ";
                    switch (System_Data.Version)
                    {
                        case 0:
                        case 2: //僅有懲
                            Learner_Data.Learner_Add("Crystal", -20);
                            Learner_Data.Learner_Add("Mistakes_Num", 1);
                            break;
                        default:
                            break;
                    }
                    t_temp.text = t_temp.text + Learner_Data.Learner_GetData("Crystal").ToString();
                }
                break;
            case 1:
                if (BattleCheck.Flag == 1) //成功
                {
                    t_temp = GameObject.Find("Text_Crystal_n").GetComponent<Text>();
                    t_temp.text = Learner_Data.Learner_GetData("Crystal").ToString() + " -> ";
                    switch (System_Data.Version)
                    {
                        case 0:
                        case 1:
                            Learner_Data.Learner_Add("Crystal", 50);
                            break;
                        default:
                            break;
                    }
                    t_temp.text = t_temp.text + Learner_Data.Learner_GetData("Crystal").ToString();
                }
                else //失敗
                {
                    t_temp = GameObject.Find("Text_Crystal_n").GetComponent<Text>();
                    t_temp.text = Learner_Data.Learner_GetData("Crystal").ToString() + " -> ";
                    switch (System_Data.Version)
                    {
                        case 0:
                        case 2: //僅有懲
                            Learner_Data.Learner_Add("Crystal", -100);
                            Learner_Data.Learner_Add("Mistakes_Num", 1);
                            break;
                        default:
                            break;
                    }
                    t_temp.text = t_temp.text + Learner_Data.Learner_GetData("Crystal").ToString();
                }
                break;
            case 2:
                if (BattleCheck.Flag == 1) //成功
                {
                    t_temp = GameObject.Find("Text_Crystal_n").GetComponent<Text>();
                    t_temp.text = Learner_Data.Learner_GetData("Crystal").ToString() + " -> ";
                    switch (System_Data.Version)
                    {
                        case 0:
                        case 1:
                            Learner_Data.Learner_Add("Crystal", 200);
                            break;
                        default:
                            break;
                    }
                    t_temp.text = t_temp.text + Learner_Data.Learner_GetData("Crystal").ToString();
                }
                else //失敗
                {
                    t_temp = GameObject.Find("Text_Crystal_n").GetComponent<Text>();
                    t_temp.text = Learner_Data.Learner_GetData("Crystal").ToString() + " -> ";
                    switch (System_Data.Version)
                    {
                        case 0:
                        case 2: //僅有懲
                            Learner_Data.Learner_Add("Crystal", -250);
                            Learner_Data.Learner_Add("Mistakes_Num", 1);
                            Learner_Data.Learner_ChangePoints_Status(2); //戰鬥點數-1
                            break;
                        default:
                            break;
                    }
                    t_temp.text = t_temp.text + Learner_Data.Learner_GetData("Crystal").ToString();
                }
                break;
            default:
                break;
        }

        if (BattleCheck.challenge == 1)
        {
            Task_Class task_temp = new Task_Class();
            task_temp = Task_Data.Battle_Get(Enemy.No);
            if (BattleCheck.Flag == 1)//成功
            {
                task_temp.ChangeStatus(4);
            }
            else if (BattleCheck.Flag == 0) //失敗
            {
                task_temp.ChangeStatus(3);
            }
        }
        BattleCheck.Flag = 0;
        BattleCheck.challenge = 0;
    }
    void ShowContent()
    {
        BQuestion_Class[] question_temp = new BQuestion_Class[5];
        Text t_temp;
        int n=5;

        if (BQuestion_Check.Question_Num < 5)
            n = BQuestion_Check.Question_Num;
        for (int i = 0; i < n; i++)
        {
            question_temp[i] = BQuestion_Data.BQuestion_Get(i);
            t_temp = GameObject.Find("Text_QNum_" + (i + 1).ToString()).GetComponent<Text>();
            t_temp.text = question_temp[i].GetQuestionNum().ToString();
            t_temp = GameObject.Find("Text_Question_" + (i + 1).ToString()).GetComponent<Text>();
            t_temp.text = question_temp[i].GetQuestion();
            t_temp = GameObject.Find("Text_Answer_" + (i + 1).ToString()).GetComponent<Text>();
            t_temp.text = question_temp[i].GetAnswer_r() + " " + question_temp[i].GetAnswer_r_Content();
            t_temp = GameObject.Find("Text_Choose_" + (i + 1).ToString()).GetComponent<Text>();
            t_temp.text = question_temp[i].GetAnswer_c() + " " + question_temp[i].GetAnswer_c_Content();
            t_temp = GameObject.Find("Text_Feedback_" + (i + 1).ToString()).GetComponent<Text>();
            t_temp.text = question_temp[i].GetFeedBack();
        }
    }

}
