using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Canvas_Task : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Text t_temp;
        Button b_temp;
        switch (System_Data.language)
        {
            case 0:
                t_temp = GameObject.Find("Text_Threshold").GetComponent<Text>();
                t_temp.text = "門檻：";
                t_temp = GameObject.Find("Text_Request").GetComponent<Text>();
                t_temp.text = "過關條件：";
                t_temp = GameObject.Find("Text_Reward").GetComponent<Text>();
                t_temp.text = "獎勵：";
                t_temp = GameObject.Find("Text_Punishment").GetComponent<Text>();
                t_temp.text = "懲罰：";
                b_temp = GameObject.Find("Button_Accept").GetComponent<Button>();
                b_temp.GetComponentInChildren<Text>().text = "接受";
                b_temp = GameObject.Find("Button_Finish").GetComponent<Button>();
                b_temp.GetComponentInChildren<Text>().text = "回報";
                b_temp = GameObject.Find("Button_Learn").GetComponent<Button>();
                b_temp.GetComponentInChildren<Text>().text = "學習";
                b_temp = GameObject.Find("Button_Battle").GetComponent<Button>();
                b_temp.GetComponentInChildren<Text>().text = "對戰";
                break;
            case 1:
                break;
            default:
                break;
        }
	}
}
