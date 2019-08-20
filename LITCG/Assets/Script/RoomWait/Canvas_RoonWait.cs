using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Canvas_RoonWait : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Text t_temp;
        t_temp = GameObject.Find("Text_A_LP_Num").GetComponent<Text>();
        t_temp.text = "20";
        t_temp = GameObject.Find("Text_A_Deck_Num").GetComponent<Text>();
        t_temp.text = Learner_Data.Learner_GetData("Cards_Num").ToString();
        switch (Enemy.No)
        {
            case 1:
                t_temp = GameObject.Find("Text_B_LP_Num").GetComponent<Text>();
                t_temp.text = "10";
                t_temp = GameObject.Find("Text_B_Deck_Num").GetComponent<Text>();
                t_temp.text = "14";
                t_temp = GameObject.Find("Text_Time_Num").GetComponent<Text>();
                t_temp.text = "10";
                t_temp = GameObject.Find("Text_Range_Num").GetComponent<Text>();
                t_temp.text = "1 - 10";
                break;
            case 2:
                t_temp = GameObject.Find("Text_B_LP_Num").GetComponent<Text>();
                t_temp.text = "15";
                t_temp = GameObject.Find("Text_B_Deck_Num").GetComponent<Text>();
                t_temp.text = "17";
                t_temp = GameObject.Find("Text_Time_Num").GetComponent<Text>();
                t_temp.text = "15";
                t_temp = GameObject.Find("Text_Range_Num").GetComponent<Text>();
                t_temp.text = "1 - 15";
                break;
            case 3:
                t_temp = GameObject.Find("Text_B_LP_Num").GetComponent<Text>();
                t_temp.text = "20";
                t_temp = GameObject.Find("Text_B_Deck_Num").GetComponent<Text>();
                t_temp.text = "20";
                t_temp = GameObject.Find("Text_Time_Num").GetComponent<Text>();
                t_temp.text = "20";
                t_temp = GameObject.Find("Text_Range_Num").GetComponent<Text>();
                t_temp.text = "1 - 20";
                break;
            default:
                break;
        }
    }
}