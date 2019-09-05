using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
static class Settlement_BattleCheck
{
    public static int PageUP = 1;
    public static int PageDown = 4;
    public static int Page = 0; //0 5 10 15

}
public class Function_Settlement_Battle : MonoBehaviour {
    public void Previous()
    {
        if (Settlement_BattleCheck.PageUP > 1)
        {
            Settlement_BattleCheck.PageUP--;
            PageChage();
        }
    }
    public void Next()
    {
        if (Settlement_BattleCheck.PageUP < Settlement_BattleCheck.PageDown)
        {
            Settlement_BattleCheck.PageUP++;
            PageChage();
        }

    }
    public void PageChage()
    {
        Text t_temp;
        t_temp = GameObject.Find("Text_PageUp").GetComponent<Text>();
        t_temp.text = Settlement_BattleCheck.PageUP.ToString();
        t_temp = GameObject.Find("Text_PageDown").GetComponent<Text>();
        t_temp.text = Settlement_BattleCheck.PageDown.ToString();

        switch (Settlement_BattleCheck.PageUP)
        {
            case 1:
                Settlement_BattleCheck.Page = 0;
                break;
            case 2:
                Settlement_BattleCheck.Page = 5;
                break;
            case 3:
                Settlement_BattleCheck.Page = 10;
                break;
            case 4:
                Settlement_BattleCheck.Page = 15;
                break;
            default:
                break;
        }
        ShowContent();
    }

    public void Back()
    {
        SceneManager.LoadScene("Battle");
    }
    void ShowContent()
    {
        BQuestion_Class[] question_temp = new BQuestion_Class[20];
        Text t_temp;
        int n = Settlement_BattleCheck.Page;
        for (int i = 0; i < BQuestion_Check.Question_total; i++)
        {
            question_temp[i] = new BQuestion_Class(0, "", "", "", "", "", "");
        }
        for (int i = 0; i < BQuestion_Check.Question_Num; i++)
        {
            question_temp[i] = BQuestion_Data.BQuestion_Get(i);
        }
        for (int i = 0; i < 5; i++)
        {
            t_temp = GameObject.Find("Text_QNum_" + (i + 1).ToString()).GetComponent<Text>();
            t_temp.text = question_temp[i+n].GetQuestionNum().ToString();
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
