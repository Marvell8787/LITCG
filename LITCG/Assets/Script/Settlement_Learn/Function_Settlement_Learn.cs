using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
static class Settlement_LearnCheck
{
    public static int PageUP = 1;
    public static int PageDown = 4;
    public static int Page = 0; //0 5 10 15

    public static int Flag = 0; //0:失敗 1:成功 2:挑戰成功
}
public class Function_Settlement_Learn : MonoBehaviour {
    public void Previous()
    {
        if (Settlement_LearnCheck.PageUP > 1)
        {
            Settlement_LearnCheck.PageUP--;
            PageChage();
        }
    }
    public void Next()
    {
        if (Settlement_LearnCheck.PageUP < Settlement_LearnCheck.PageDown)
        {
            Settlement_LearnCheck.PageUP++;
            PageChage();
        }

    }
    public void PageChage()
    {
        Text t_temp;
        t_temp = GameObject.Find("Text_PageUp").GetComponent<Text>();
        t_temp.text = Settlement_LearnCheck.PageUP.ToString();
        t_temp = GameObject.Find("Text_PageDown").GetComponent<Text>();
        t_temp.text = Settlement_LearnCheck.PageDown.ToString();

        switch (Settlement_LearnCheck.PageUP)
        {
            case 1:
                Settlement_LearnCheck.Page = 0;
                break;
            case 2:
                Settlement_LearnCheck.Page = 5;
                break;
            case 3:
                Settlement_LearnCheck.Page = 10;
                break;
            case 4:
                Settlement_LearnCheck.Page = 15;
                break;
            default:
                break;
        }
        ShowContent();
    }
    public void Back()
    {
        SceneManager.LoadScene("Learn");
    }
    void ShowContent()
    {
        Question_Class[] question_temp = new Question_Class[20];
        Text t_temp;
        int n = Settlement_LearnCheck.Page;
        for (int i = 0; i < 20; i++)
        {
            question_temp[i] = new Question_Class(0, "", "", "", "", "", "");
        }
        for (int i = 0; i < Question_Check.Question_total; i++)
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
            t_temp.text = question_temp[i + n].GetAnswer_r() + " " + question_temp[i + n].GetAnswer_r_Content();
            t_temp = GameObject.Find("Text_Choose_" + (i + 1).ToString()).GetComponent<Text>();
            t_temp.text = question_temp[i + n].GetAnswer_c() + " " + question_temp[i + n].GetAnswer_c_Content();
            t_temp = GameObject.Find("Text_Feedback_" + (i + 1).ToString()).GetComponent<Text>();
            t_temp.text = question_temp[i + n].GetFeedBack();
        }
    }
}
