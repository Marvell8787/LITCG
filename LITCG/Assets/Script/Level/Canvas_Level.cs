using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Canvas_Level : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Button b_temp;
        Text t_temp;

        ClearAllText();
        b_temp = GameObject.Find("Button_Challenge").GetComponent<Button>();
        b_temp.interactable = false;

        Level_Class[] level_temp = new Level_Class[6];
        for (int i = 0; i < 6; i++)
        {
            level_temp[i] = Level_Data.Level_Get(i);
        }

        b_temp = GameObject.Find("Button_Overall").GetComponent<Button>();
        b_temp.interactable = true;

        t_temp = GameObject.Find("Text_CoinContent").GetComponent<Text>();
        t_temp.text = Learner_Data.Learner_GetData("Coin").ToString();

        switch (System_Data.language)
        {
            case 0:
                t_temp = GameObject.Find("Text_QuestionType").GetComponent<Text>();
                t_temp.text = "題型：";
                t_temp = GameObject.Find("Text_Range").GetComponent<Text>();
                t_temp.text = "範圍：";
                t_temp = GameObject.Find("Text_Reward").GetComponent<Text>();
                t_temp.text = "獎勵：";
                t_temp = GameObject.Find("Text_Punishment").GetComponent<Text>();
                t_temp.text = "懲罰：";
                t_temp = GameObject.Find("Text_HighestScore").GetComponent<Text>();
                t_temp.text = "最高紀錄：";
                b_temp = GameObject.Find("Button_Practice").GetComponent<Button>();
                b_temp.GetComponentInChildren<Text>().text = "練習";
                b_temp = GameObject.Find("Button_Challenge").GetComponent<Button>();
                b_temp.GetComponentInChildren<Text>().text = "挑戰";
                b_temp = GameObject.Find("Button_Back").GetComponent<Button>();
                b_temp.GetComponentInChildren<Text>().text = "返回";
                break;
            default:
                break;
        }

    }
    public void ClearAllText()
    {
        Text t_temp;
        t_temp = GameObject.Find("Text_QuestionTypeContent").GetComponent<Text>();
        t_temp.text = "";
        t_temp = GameObject.Find("Text_RangeContent").GetComponent<Text>();
        t_temp.text = "";
        t_temp = GameObject.Find("Text_RewardContent").GetComponent<Text>();
        t_temp.text = "";
        t_temp = GameObject.Find("Text_PunishmentContent").GetComponent<Text>();
        t_temp.text = "";
        t_temp = GameObject.Find("Text_HighestScoreContent").GetComponent<Text>();
        t_temp.text = "";
    }
}
