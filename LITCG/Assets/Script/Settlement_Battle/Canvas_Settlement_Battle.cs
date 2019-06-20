using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Canvas_Settlement_Battle : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Text t_temp;
        t_temp = GameObject.Find("Text_I_Win_Num").GetComponent<Text>();
        t_temp.text = Learner_Data.Learner_GetData("Battle_Win").ToString();
        t_temp = GameObject.Find("Text_I_Lose_Num").GetComponent<Text>();
        t_temp.text = Learner_Data.Learner_GetData("Battle_Lose").ToString();
    }

}
