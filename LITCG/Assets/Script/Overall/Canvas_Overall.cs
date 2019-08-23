using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Canvas_Overall : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Text t_temp;
        Button b_temp;

        Question_Class question_temp = new Question_Class();

        Question_Check.Score = 0;
        Question_Check.Question_Num = 0; //init

        Question_Data.Question_Init();
        ClearAllText();

        question_temp = Question_Data.Question_Overall_Get(0);

        switch (System_Data.language)
        {
            case 0:
                t_temp = GameObject.Find("Text_QuestionType").GetComponent<Text>();
                t_temp.text = "題    型：";
                t_temp = GameObject.Find("Text_QuestionTypeContent").GetComponent<Text>();
                t_temp.text = "拼字";
                t_temp = GameObject.Find("Text_Level").GetComponent<Text>();
                t_temp.text = "關卡：";
                t_temp = GameObject.Find("Text_description").GetComponent<Text>();
                t_temp.text = "請拼出正確的單字：";
                t_temp = GameObject.Find("Text_Answer").GetComponent<Text>();
                t_temp.text = "解答：";
                t_temp = GameObject.Find("Text_Score").GetComponent<Text>();
                t_temp.text = "分數：";
                b_temp = GameObject.Find("Button_Submit").GetComponent<Button>();
                b_temp.GetComponentInChildren<Text>().text = "確定";
                b_temp = GameObject.Find("Button_Next").GetComponent<Button>();
                b_temp.GetComponentInChildren<Text>().text = "下一題";
                break;
            default:
                break;
        }

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
