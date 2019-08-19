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
    public void Change(int index)
    {
        Dropdown d_temp;
        switch (index)
        {
            case 0:
                System_Data.Version = 0;
                Debug.Log(System_Data.Version);
                break;
            case 1:
                System_Data.Version = 1;
                Debug.Log(System_Data.Version);
                break;
            case 2:
                System_Data.Version = 2;
                Debug.Log(System_Data.Version);
                break;
            case 3:
                System_Data.Version = 3;
                Debug.Log(System_Data.Version);
                break;
            default:
                break;
        }
        d_temp = GameObject.Find("Dropdown").GetComponent<Dropdown>();
        d_temp.interactable = false;
    }
}
