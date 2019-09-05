using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Canvas_Home : MonoBehaviour {

    private static string[] C_GameGoal = new string[8] { "", "", "", "", "", "", "", "" };
    private static string[] E_GameGoal = new string[8] { "", "", "", "", "", "", "", "" };
    // Use this for initialization
    void Start () {
        Text t_temp;
        Button b_temp;
        GameGoal_Data.GameGoal_Init();

        for(int i = 0; i < 8; i++)
        {
            switch (System_Data.language)
            {
                case 0:
                    C_GameGoal[i]=GameGoal_Data.GameGoal_Get(i);
                    break;
                case 1:
                    E_GameGoal[i] = GameGoal_Data.GameGoal_Get(i);
                    break;
                default:
                    C_GameGoal[i] = GameGoal_Data.GameGoal_Get(i);
                    break;
            }
        }
        ClearAllText();
        switch (System_Data.language)
        {
            case 0:
                for (int i = 0; i < C_GameGoal.Length; i++)
                {
                    t_temp = GameObject.Find("Text_GameGoal_" + (i + 1).ToString()).GetComponent<Text>();
                    t_temp.text = C_GameGoal[i];
                }

                break;
            default:
                for (int i = 0; i <E_GameGoal.Length; i++)
                {
                    t_temp = GameObject.Find("Text_GameGoal_" + (i + 1).ToString()).GetComponent<Text>();
                    t_temp.text = E_GameGoal[i];
                }

                b_temp = GameObject.Find("Button_Task").GetComponent<Button>();
                b_temp.GetComponentInChildren<Text>().text = "Task";
                b_temp = GameObject.Find("Button_Learn").GetComponent<Button>();
                b_temp.GetComponentInChildren<Text>().text = "Learn";
                b_temp = GameObject.Find("Button_Deck").GetComponent<Button>();
                b_temp.GetComponentInChildren<Text>().text = "Deck";
                b_temp = GameObject.Find("Button_Battle").GetComponent<Button>();
                b_temp.GetComponentInChildren<Text>().text = "Battle";
                b_temp = GameObject.Find("Button_Shop").GetComponent<Button>();
                b_temp.GetComponentInChildren<Text>().text = "Shop";
                b_temp = GameObject.Find("Button_Profile").GetComponent<Button>();
                b_temp.GetComponentInChildren<Text>().text = "Profile";
                b_temp = GameObject.Find("Button_GameGoals").GetComponent<Button>();
                b_temp.GetComponentInChildren<Text>().text = "GameGoals";
                b_temp = GameObject.Find("Button_Guide").GetComponent<Button>();
                b_temp.GetComponentInChildren<Text>().text = "Guide";
                b_temp = GameObject.Find("Button_Rank").GetComponent<Button>();
                b_temp.GetComponentInChildren<Text>().text = "Rank";
                b_temp = GameObject.Find("Button_Badges").GetComponent<Button>();
                b_temp.GetComponentInChildren<Text>().text = "Badges";
                break;
        }
    }
    public void ClearAllText()
    {
        Text t_temp;
        for (int i = 0; i < 8; i++)
        {
            t_temp = GameObject.Find("Text_GameGoal_" + (i + 1).ToString()).GetComponent<Text>();
            t_temp.text = "";
            t_temp = GameObject.Find("Text_GameGoal_" + (i + 1).ToString() + "_Content").GetComponent<Text>();
            t_temp.text = "";
        }
    }
}
