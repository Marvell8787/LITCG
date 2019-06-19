using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Canvas_Shop : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Text T_Temp;
        T_Temp = GameObject.Find("Text_CoinContent").GetComponent<Text>();
        T_Temp.text = Learner_Data.Learner_GetData("Coin").ToString();
    }

}
