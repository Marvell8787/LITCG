using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Function_Home : MonoBehaviour {

    // Show Button
    public void GameGoals()
    {
        Text t_temp;
        for (int i=0;i<8;i++)
        {
            t_temp = GameObject.Find("Text_GameGoal_" + (i + 1).ToString()).GetComponent<Text>();
            t_temp.text = GameGoal_Data.GameGoal[i];
        }
    }
    public void Status()
    {
        //Text t_temp;
        for (int i = 0; i < 8; i++)
        {
            //t_temp = GameObject.Find("Text_GameGoal_" + (i + 1).ToString()).GetComponent<Text>();
            //t_temp.text = GameGoal_Data.GameGoal[i];
        }
    }
    //GO Button
    public void Task()
    {
        Application.LoadLevel("Task");
    }
    public void Learn()
    {
        Application.LoadLevel("Learn");
    }
    public void Deck()
    {
        Application.LoadLevel("Deck");
    }
    public void Battle()
    {
        //Application.LoadLevel("Battle");
    }
    public void Shop()
    {
        Application.LoadLevel("Shop");
    }
    public void Profile()
    {
        Application.LoadLevel("Profile");
    }
    public void Introduction()
    {
        Application.LoadLevel("Introduction");
    }


}
