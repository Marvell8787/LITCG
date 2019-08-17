using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Canvas_Home : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Text t_temp;
        switch (System_Data.language)
        {
            case 0:
                for (int i = 0; i < GameGoal_Data.C_Item.Length; i++)
                {
                    t_temp = GameObject.Find("Text_Item_" + (i + 1).ToString()).GetComponent<Text>();
                    t_temp.text = GameGoal_Data.C_Item[i];
                }
                break;
            default:
                for (int i = 0; i < GameGoal_Data.E_Item.Length; i++)
                {
                    t_temp = GameObject.Find("Text_Item_" + (i + 1).ToString()).GetComponent<Text>();
                    t_temp.text = GameGoal_Data.E_Item[i];
                }
                break;
        }
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
        for (int i = 0; i < 7; i++)
        {
            t_temp = GameObject.Find("Text_Item_" + (i + 1).ToString()).GetComponent<Text>();
            t_temp.text = "";
        }
        t_temp = GameObject.Find("Text_ScoreContent").GetComponent<Text>();
        t_temp.text = "";
        t_temp = GameObject.Find("Text_CoinContent").GetComponent<Text>();
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
