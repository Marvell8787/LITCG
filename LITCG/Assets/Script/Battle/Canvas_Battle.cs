using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Canvas_Battle : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Text T_Temp;

        T_Temp = GameObject.Find("Text_Win_Num").GetComponent<Text>();
        T_Temp.text = Learner_Data.Learner_GetData("Battle_Win").ToString();
        T_Temp = GameObject.Find("Text_Lose_Num").GetComponent<Text>();
        T_Temp.text = Learner_Data.Learner_GetData("Battle_Lose").ToString();


    }

    // Update is called once per frame
    void Update () {
		
	}
}
