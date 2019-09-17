using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Canvas_RoonWait : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Button b_temp;
        Text t_temp;

        Task_Class task_temp = new Task_Class();
        task_temp = Task_Data.Battle_Get(Enemy.No);

        t_temp = GameObject.Find("Text_A_LP_Num").GetComponent<Text>();
        t_temp.text = "20";
        t_temp = GameObject.Find("Text_A_Deck_Num").GetComponent<Text>();
        t_temp.text = Learner_Data.Learner_GetData("Cards_Num").ToString();
        switch (System_Data.language)
        {
            case 0:
                t_temp = GameObject.Find("Text_A").GetComponent<Text>();
                t_temp.text = "我方";
                t_temp = GameObject.Find("Text_B").GetComponent<Text>();
                t_temp.text = "電腦";
                t_temp = GameObject.Find("Text_A_Deck").GetComponent<Text>();
                t_temp.text = "牌組：";
                t_temp = GameObject.Find("Text_B_Deck").GetComponent<Text>();
                t_temp.text = "牌組：";
                t_temp = GameObject.Find("Text_Time").GetComponent<Text>();
                t_temp.text = "回合數";
                t_temp = GameObject.Find("Text_Range").GetComponent<Text>();
                t_temp.text = "題目範圍";
                b_temp = GameObject.Find("Button_Back").GetComponent<Button>();
                b_temp.GetComponentInChildren<Text>().text = "返回";
                b_temp = GameObject.Find("Button_Play").GetComponent<Button>();
                b_temp.GetComponentInChildren<Text>().text = "練習";
                b_temp = GameObject.Find("Button_Challenge").GetComponent<Button>();
                b_temp.GetComponentInChildren<Text>().text = "挑戰";
                break;
            default:
                break;
        }

        switch (Enemy.No)
        {
            case 0:
                t_temp = GameObject.Find("Text_B_LP_Num").GetComponent<Text>();
                t_temp.text = "10";
                t_temp = GameObject.Find("Text_B_Deck_Num").GetComponent<Text>();
                t_temp.text = "14";
                t_temp = GameObject.Find("Text_Time_Num").GetComponent<Text>();
                t_temp.text = "5";
                t_temp = GameObject.Find("Text_Range_Num").GetComponent<Text>();
                t_temp.text = "1 - 10";
                break;
            case 1:
                t_temp = GameObject.Find("Text_B_LP_Num").GetComponent<Text>();
                t_temp.text = "15";
                t_temp = GameObject.Find("Text_B_Deck_Num").GetComponent<Text>();
                t_temp.text = "17";
                t_temp = GameObject.Find("Text_Time_Num").GetComponent<Text>();
                t_temp.text = "10";
                t_temp = GameObject.Find("Text_Range_Num").GetComponent<Text>();
                t_temp.text = "1 - 15";
                break;
            case 2:
                t_temp = GameObject.Find("Text_B_LP_Num").GetComponent<Text>();
                t_temp.text = "20";
                t_temp = GameObject.Find("Text_B_Deck_Num").GetComponent<Text>();
                t_temp.text = "20";
                t_temp = GameObject.Find("Text_Time_Num").GetComponent<Text>();
                t_temp.text = "15";
                t_temp = GameObject.Find("Text_Range_Num").GetComponent<Text>();
                t_temp.text = "1 - 20";
                break;
            default:
                break;
        }

        if (task_temp.GetStatus() == 2)
        {
            b_temp = GameObject.Find("Button_Challenge").GetComponent<Button>();
            b_temp.interactable = true;
        }
        else
        {
            b_temp = GameObject.Find("Button_Challenge").GetComponent<Button>();
            b_temp.interactable = false;
        }

    }
}