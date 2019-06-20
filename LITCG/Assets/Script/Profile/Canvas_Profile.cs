using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Canvas_Profile : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Text T_Temp;

        T_Temp = GameObject.Find("Text_CardsContent").GetComponent<Text>();
        T_Temp.text = Learner_Data.Learner_GetData("Cards_Num").ToString();
        T_Temp = GameObject.Find("Text_BadgesContent").GetComponent<Text>();
        T_Temp.text = Learner_Data.Learner_GetData("Badges_Num").ToString();
        T_Temp = GameObject.Find("Text_PointsContent").GetComponent<Text>();
        T_Temp.text = Learner_Data.Learner_GetData("Points_Num").ToString();
        T_Temp = GameObject.Find("Text_MistakesContent").GetComponent<Text>();
        T_Temp.text = Learner_Data.Learner_GetData("Mistakes_Num").ToString();


    }

}
