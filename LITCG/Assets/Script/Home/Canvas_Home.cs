using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Canvas_Home : MonoBehaviour {

	// Use this for initialization
	void Start () {
        ClearAllText();

    }
    public void ClearAllText()
    {
        Text t_temp;
        for (int i = 0; i < 8; i++)
        {
            t_temp = GameObject.Find("Text_GameGoal_" + (i + 1).ToString()).GetComponent<Text>();
            t_temp.text = "";
        }
        t_temp = GameObject.Find("Text_ScoreContent").GetComponent<Text>();
        t_temp.text = "";
        t_temp = GameObject.Find("Text_MoneyContent").GetComponent<Text>();
        t_temp.text = "";
        t_temp = GameObject.Find("Text_CrystalContent").GetComponent<Text>();
        t_temp.text = "";
        t_temp = GameObject.Find("Text_CardsContent").GetComponent<Text>();
        t_temp.text = "";
        t_temp = GameObject.Find("Text_BadgesContent").GetComponent<Text>();
        t_temp.text = "";
        t_temp = GameObject.Find("Text_PointsContent").GetComponent<Text>();
        t_temp.text = "";
        t_temp = GameObject.Find("Text_MistakesContent").GetComponent<Text>();
        t_temp.text = "";
    }
}
