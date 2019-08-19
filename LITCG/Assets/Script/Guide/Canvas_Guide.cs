using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Canvas_Guide : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Text t_temp;
        Button b_temp;


        t_temp = GameObject.Find("Text_Content").GetComponent<Text>();
        switch (System_Data.language)
        {
            case 0:
                t_temp.text = Guide_Bank.C_Init_Content;
                break;
            case 1:
                t_temp.text = Guide_Bank.E_Init_Content;
                b_temp = GameObject.Find("Button_Task").GetComponent<Button>();
                b_temp.GetComponentInChildren<Text>().text = "Task";
                b_temp = GameObject.Find("Button_Learn").GetComponent<Button>();
                b_temp.GetComponentInChildren<Text>().text = "Learn";
                b_temp = GameObject.Find("Button_Battle").GetComponent<Button>();
                b_temp.GetComponentInChildren<Text>().text = "Battle";
                b_temp = GameObject.Find("Button_Item").GetComponent<Button>();
                b_temp.GetComponentInChildren<Text>().text = "Item";
                b_temp = GameObject.Find("Button_Previous").GetComponent<Button>();
                b_temp.GetComponentInChildren<Text>().text = "Previous";
                b_temp = GameObject.Find("Button_Next").GetComponent<Button>();
                b_temp.GetComponentInChildren<Text>().text = "Next";
                break;
            default:
                t_temp.text = Guide_Bank.C_Init_Content;
                break;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
