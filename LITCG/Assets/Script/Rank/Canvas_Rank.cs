using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Canvas_Rank : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Button b_temp;
        switch (System_Data.language)
        {
            case 0:
                b_temp = GameObject.Find("Button_Back").GetComponent<Button>();
                b_temp.GetComponentInChildren<Text>().text = "返回";
                b_temp = GameObject.Find("Button_Update").GetComponent<Button>();
                b_temp.GetComponentInChildren<Text>().text = "更新";
                break;
            case 1:
                break;
            default:
                break;
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
