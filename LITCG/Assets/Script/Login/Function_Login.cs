using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Function_Login : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	public void Login()
    {
        Application.LoadLevel("Guide");
    }
    public void Chinese()
    {
        System_Data.language = 0;

        Button b_temp;
        b_temp = GameObject.Find("Button_Login").GetComponent<Button>();
        b_temp.GetComponentInChildren<Text>().text = "登入";
    }
    public void English()
    {
        System_Data.language = 1;

        Button b_temp;
        b_temp = GameObject.Find("Button_Login").GetComponent<Button>();
        b_temp.GetComponentInChildren<Text>().text = "Login";
    }
}
