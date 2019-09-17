﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Canvas_Shop : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Text t_temp;
        Button b_temp;
        t_temp = GameObject.Find("Text_CoinContent").GetComponent<Text>();
        t_temp.text = Learner_Data.Learner_GetData("Coin").ToString();

        switch (System_Data.language)
        {
            case 0:
                t_temp = GameObject.Find("Text_Coin").GetComponent<Text>();
                t_temp.text = "金幣：";
                t_temp = GameObject.Find("Text_Description").GetComponent<Text>();
                t_temp.text = "訊息";
                b_temp = GameObject.Find("Button_Back").GetComponent<Button>();
                b_temp.GetComponentInChildren<Text>().text = "返回";
                for (int i = 1; i <= 4; i++)
                {
                    b_temp = GameObject.Find("Button_Buy_" + i.ToString()).GetComponent<Button>();
                    b_temp.GetComponentInChildren<Text>().text = "購買";
                }
                break;
            default:
                break;
        }
        for (int i = 1; i <= 4; i++)
        {
            b_temp = GameObject.Find("Button_Buy_" + i.ToString()).GetComponent<Button>();
            if(Learner_Data.Learner_GetCard_Status(i+6) ==1)
                b_temp.interactable = false;
        }
    }

}
