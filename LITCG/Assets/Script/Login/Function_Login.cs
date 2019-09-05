using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Function_Login : MonoBehaviour {

	// Use this for initialization
	void Start () {

    }
	public void Login()
    {
        InputField in_temp;

        Task_Data.Task_Init();

        in_temp = GameObject.Find("InputField_ID").GetComponent<InputField>();
        System_Data.ID =in_temp.GetComponentInChildren<Text>().text;
        in_temp = GameObject.Find("InputField_Password").GetComponent<InputField>();
        System_Data.Password = in_temp.GetComponentInChildren<Text>().text;
        in_temp = GameObject.Find("InputField_Nickname").GetComponent<InputField>();
        System_Data.Nickname = in_temp.GetComponentInChildren<Text>().text;

        SceneManager.LoadScene("Home");        
    }
    public void Chinese()
    {
        Button b_temp;
        InputField in_temp;

        System_Data.language = 0;

        b_temp = GameObject.Find("Button_Login").GetComponent<Button>();
        b_temp.GetComponentInChildren<Text>().text = "登入";
        in_temp = GameObject.Find("InputField_ID").GetComponent<InputField>();
        in_temp.GetComponentInChildren<Text>().text = "帳號";
        in_temp = GameObject.Find("InputField_Password").GetComponent<InputField>();
        in_temp.GetComponentInChildren<Text>().text = "密碼";
        in_temp = GameObject.Find("InputField_Nickname").GetComponent<InputField>();
        in_temp.GetComponentInChildren<Text>().text = "暱稱";
    }
    public void English()
    {
        Button b_temp;
        InputField in_temp;

        System_Data.language = 1;

        b_temp = GameObject.Find("Button_Login").GetComponent<Button>();
        b_temp.GetComponentInChildren<Text>().text = "Login";
        in_temp = GameObject.Find("InputField_ID").GetComponent<InputField>();
        in_temp.GetComponentInChildren<Text>().text = "ID";
        in_temp = GameObject.Find("InputField_Password").GetComponent<InputField>();
        in_temp.GetComponentInChildren<Text>().text = "Password";
        in_temp = GameObject.Find("InputField_Nickname").GetComponent<InputField>();
        in_temp.GetComponentInChildren<Text>().text = "Nickname";
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
