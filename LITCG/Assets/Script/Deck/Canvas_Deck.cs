using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Canvas_Deck : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Text T_temp;

        Card_Data.Card_Init();
        T_temp = GameObject.Find("Text_DescriptionContent").GetComponent<Text>();
        T_temp.text = "";
    }
}
