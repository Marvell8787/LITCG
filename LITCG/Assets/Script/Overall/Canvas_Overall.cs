using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Canvas_Overall : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Text t_temp;
        Question_Class question_temp = new Question_Class();

        Question_Check.Score = 0;
        Question_Check.Question_Num = 0; //init

        Question_Data.Question_Init();
        ClearAllText();

        question_temp = Question_Data.Question_Overall_Get(0);

        t_temp = GameObject.Find("Text_QuestionNum").GetComponent<Text>();
        t_temp.text = (Question_Check.Question_Num + 1).ToString() + ".";
        t_temp = GameObject.Find("Text_Question").GetComponent<Text>();
        t_temp.text = question_temp.GetQuestion();

    }
    public void ClearAllText()
    {
        Text t_temp;
        t_temp = GameObject.Find("Text_AnswerContent").GetComponent<Text>();
        t_temp.text = "";
        t_temp = GameObject.Find("Text_FeedBack").GetComponent<Text>();
        t_temp.text = "";
        t_temp = GameObject.Find("Text_Question").GetComponent<Text>();
        t_temp.text = "";
        t_temp = GameObject.Find("Text_ENDContent").GetComponent<Text>();
        t_temp.text = "";
    }

}
