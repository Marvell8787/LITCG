using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Canvas_Settlement_Learn : MonoBehaviour {

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
                t_temp = GameObject.Find("Text_Flag").GetComponent<Text>();
                /*if (BattleCheck.Flag == 0)
                    t_temp.text = "失敗 !";
                else
                    t_temp.text = "勝利 !";*/
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

        if (Question_Check.Question_Num < 6)
            Settlement_LearnCheck.PageDown = 1;
        else if (Question_Check.Question_Num < 11)
            Settlement_LearnCheck.PageDown = 2;
        else if (Question_Check.Question_Num < 16)
            Settlement_LearnCheck.PageDown = 3;
        else
            Settlement_LearnCheck.PageDown = 4;

        Settlement_LearnCheck.Page = 0;
        Settlement_LearnCheck.PageUP = 1;

        t_temp = GameObject.Find("Text_PageUp").GetComponent<Text>();
        t_temp.text = Settlement_LearnCheck.PageUP.ToString();
        t_temp = GameObject.Find("Text_PageDown").GetComponent<Text>();
        t_temp.text = Settlement_LearnCheck.PageDown.ToString();


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

    }

    void ShowContent()
    {
        Question_Class[] question_temp = new Question_Class[20];
        Text t_temp;
        int n = Settlement_LearnCheck.Page;
        for (int i = 0; i < Question_Check.Question_total; i++)
        {
            question_temp[i] = new Question_Class(0, "", "", "", "", "", "");
        }
        for (int i = 0; i < Question_Check.Question_Num; i++)
        {
            question_temp[i] = Question_Data.Question_Get(i);
        }
        for (int i = 0; i < 5; i++)
        {
            t_temp = GameObject.Find("Text_QNum_" + (i + 1).ToString()).GetComponent<Text>();
            t_temp.text = question_temp[i + n].GetQuestionNum().ToString();
            t_temp = GameObject.Find("Text_Question_" + (i + 1).ToString()).GetComponent<Text>();
            t_temp.text = question_temp[i + n].GetQuestion();
            t_temp = GameObject.Find("Text_Answer_" + (i + 1).ToString()).GetComponent<Text>();
            t_temp.text = question_temp[i + n].GetAnswer_r() + " " + question_temp[i].GetAnswer_r_Content();
            t_temp = GameObject.Find("Text_Choose_" + (i + 1).ToString()).GetComponent<Text>();
            t_temp.text = question_temp[i + n].GetAnswer_c() + " " + question_temp[i].GetAnswer_c_Content();
            t_temp = GameObject.Find("Text_Feedback_" + (i + 1).ToString()).GetComponent<Text>();
            t_temp.text = question_temp[i + n].GetFeedBack();
        }
    }

}
