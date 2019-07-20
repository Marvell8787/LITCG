using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Canvas_Level_Learn : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Text t_temp;
        Image i_Temp;
        Level_Class[] level_temp = new Level_Class[7];
        Question_Class question_temp = new Question_Class();

        Question_Data.Question_Init();
        ClearAllText();
        Question_Check.Score = 0;
        Question_Check.Question_Num = 0; //init

        question_temp = Question_Data.Question_Get(0);

        for (int i = 0; i < 7; i++)
        {
            level_temp[i] = Level_Data.Level_Get(i);
        }

        t_temp = GameObject.Find("Text_QuestionTypeContent").GetComponent<Text>();
        t_temp.text = level_temp[Level_Check.choose].GetQuestionType();
        t_temp = GameObject.Find("Text_LevelContent").GetComponent<Text>();
        t_temp.text = level_temp[Level_Check.choose].GetTitle();

        switch (Level_Check.choose)
        {
            case 0: //Level-1 聽力
            case 1: //Level-2 聽力
            case 2: //Level-3 聽力
                t_temp = GameObject.Find("Text_Question").GetComponent<Text>();
                t_temp.text = "Please click on the pattern on the left to select the correct answer based on what you hear and from the options below.";
                i_Temp = GameObject.Find("Image_Question").GetComponent<Image>();
                i_Temp.sprite = Resources.Load("Image/Voice", typeof(Sprite)) as Sprite;
                Question_Data.Button_Ans_Set();
                break;
            case 3: //Level-4 中文
            case 4: //Level-5 中文
            case 5: //Level-6 中文
                t_temp = GameObject.Find("Text_Question").GetComponent<Text>();
                t_temp.text = question_temp.GetQuestion();
                i_Temp = GameObject.Find("Image_Question").GetComponent<Image>();
                i_Temp.sprite = Resources.Load("", typeof(Sprite)) as Sprite;
                Question_Data.Button_Ans_Set();
                break;
            default:
                break;
        }
        t_temp = GameObject.Find("Text_QuestionNum").GetComponent<Text>();
        t_temp.text = (Question_Check.Question_Num+1).ToString() + ".";


    }
    public void ClearAllText()
    {
        Text t_temp;
        t_temp = GameObject.Find("Text_QuestionTypeContent").GetComponent<Text>();
        t_temp.text = "";
        t_temp = GameObject.Find("Text_LevelContent").GetComponent<Text>();
        t_temp.text = "";
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
