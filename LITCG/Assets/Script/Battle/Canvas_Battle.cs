using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Canvas_Battle : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Button b_temp;
        Text t_temp;


        t_temp = GameObject.Find("Text_Win_Num").GetComponent<Text>();
        t_temp.text = Learner_Data.Learner_GetData("Battle_Win").ToString();
        t_temp = GameObject.Find("Text_Lose_Num").GetComponent<Text>();
        t_temp.text = Learner_Data.Learner_GetData("Battle_Lose").ToString();

        switch (System_Data.language)
        {
            case 0:
                b_temp = GameObject.Find("Button_Back").GetComponent<Button>();
                b_temp.GetComponentInChildren<Text>().text = "返回";
                break;
            default:
                break;
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
