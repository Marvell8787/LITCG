using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Function_Overall : MonoBehaviour {

    public void Submit()
    {
        string s;
        s = GameObject.Find("InputField_Ans").GetComponent<InputField>().text;
        CheckAns(s);
    }
    public void Next()
    {
        Button b_temp;
        Text t_temp;
        Question_Class question_temp = new Question_Class();

        b_temp = GameObject.Find("Button_Next").GetComponent<Button>();
        b_temp.interactable = false;
        b_temp = GameObject.Find("Button_Submit").GetComponent<Button>();
        b_temp.interactable = true;

        if (Question_Check.Question_Num == 9)
        {
            if (Question_Check.Score > Level_Data.GetHighestScore(Level_Check.choose))
            {
                Level_Data.ChangeHighestScore(Question_Check.Score.ToString(), Level_Check.choose);

            }
            Application.LoadLevel("Settlement_Learn");
        }
        else
        {
            Question_Check.Question_Num++;
            question_temp = Question_Data.Question_Overall_Get(Question_Check.Question_Num);
            t_temp = GameObject.Find("Text_QuestionNum").GetComponent<Text>();
            t_temp.text = (Question_Check.Question_Num + 1).ToString() + ".";
            t_temp = GameObject.Find("Text_AnswerContent").GetComponent<Text>();
            t_temp.text = "";
            t_temp = GameObject.Find("Text_FeedBack").GetComponent<Text>();
            t_temp.text = "";

            t_temp = GameObject.Find("Text_Question").GetComponent<Text>();
            t_temp.text = question_temp.GetQuestion();
        }

    }
    public void CheckAns(string s)
    {
        Text t_temp;
        Button b_temp;
        Question_Class question_temp = new Question_Class();

        Question_Data.ChangeAnswer_c_Content_O(Question_Check.Choose_Ans_Content, Question_Check.Question_Num);

        question_temp = Question_Data.Question_Overall_Get(Question_Check.Question_Num);

        if (question_temp.GetAnswer_r_Content() == s)
        {
            Question_Data.ChangeFeedBack_O("O", Question_Check.Question_Num);
            t_temp = GameObject.Find("Text_FeedBack").GetComponent<Text>();
            t_temp.text = "O";
            Question_Check.Score += 10;
        }
        else
        {
            Question_Data.ChangeFeedBack_O("X", Question_Check.Question_Num);
            t_temp = GameObject.Find("Text_FeedBack").GetComponent<Text>();
            t_temp.text = "X";
        }
        t_temp = GameObject.Find("Text_AnswerContent").GetComponent<Text>();
        t_temp.text = question_temp.GetAnswer_r_Content();
        t_temp = GameObject.Find("Text_ScoreContent").GetComponent<Text>();
        t_temp.text = Question_Check.Score.ToString();

        b_temp = GameObject.Find("Button_Next").GetComponent<Button>();
        b_temp.interactable = true;
        b_temp = GameObject.Find("Button_Submit").GetComponent<Button>();
        b_temp.interactable = false;

        if (Question_Check.Question_Num == 9)
        {
            t_temp = GameObject.Find("Text_ENDContent").GetComponent<Text>();
            t_temp.text = "END";
        }
    }
}
