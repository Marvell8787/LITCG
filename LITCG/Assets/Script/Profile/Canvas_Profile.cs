using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Canvas_Profile : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Button b_temp;

        switch (System_Data.language)
        {
            case 0:
                b_temp = GameObject.Find("Button_Back").GetComponent<Button>();
                b_temp.GetComponentInChildren<Text>().text = "返回";
                break;
            case 1:
                break;

        }
        /*
        t_temp = GameObject.Find("Text_CardsContent").GetComponent<Text>();
        t_temp.text = Learner_Data.Learner_GetData("Cards_Num").ToString();
        t_temp = GameObject.Find("Text_BadgesContent").GetComponent<Text>();
        t_temp.text = Learner_Data.Learner_GetData("Badges_Num").ToString();
        t_temp = GameObject.Find("Text_PointsContent").GetComponent<Text>();
        t_temp.text = Learner_Data.Learner_GetData("Points_Num").ToString();
        t_temp = GameObject.Find("Text_MistakesContent").GetComponent<Text>();
        t_temp.text = Learner_Data.Learner_GetData("Mistakes_Num").ToString();*/


    }

}
