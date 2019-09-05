using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Function_Home : MonoBehaviour {

    // Show Button
    public void GameGoals()
    {
        Text t_temp;
        Button b_temp;

        //根據獎懲做分岐
        t_temp = GameObject.Find("Text_GameGoal_1_Content").GetComponent<Text>();
        t_temp.text = Learner_Data.Learner_GetData("Task_Finish").ToString() + " / " + Item_Data.Task;
        t_temp = GameObject.Find("Text_GameGoal_2_Content").GetComponent<Text>();
        t_temp.text = Learner_Data.Learner_GetData("Learn_Finish").ToString() + " / " + Item_Data.Learn;
        //獎懲皆無以外
        if (System_Data.Version < 3)
        {
            if (System_Data.Version == 2)
            {
                Item_Data.Score = "0";
                Item_Data.Crystal = "0";
            }
            t_temp = GameObject.Find("Text_GameGoal_3_Content").GetComponent<Text>();
            t_temp.text = Learner_Data.Learner_GetData("Score").ToString() + " / " + Item_Data.Score;
            t_temp = GameObject.Find("Text_GameGoal_4_Content").GetComponent<Text>();
            t_temp.text = Learner_Data.Learner_GetData("Crystal").ToString() + " / " + Item_Data.Crystal;

            switch (System_Data.Version)
            {
                case 0: //獎懲皆有
                    t_temp = GameObject.Find("Text_GameGoal_5_Content").GetComponent<Text>();
                    t_temp.text = Learner_Data.Learner_GetData("Cards_Num").ToString() + " / " + Item_Data.Cards;
                    t_temp = GameObject.Find("Text_GameGoal_6_Content").GetComponent<Text>();
                    t_temp.text = Learner_Data.Learner_GetData("Badges_Num").ToString() + " / " + Item_Data.Badges;
                    t_temp = GameObject.Find("Text_GameGoal_7_Content").GetComponent<Text>();
                    t_temp.text = Learner_Data.Learner_GetData("Points_Num").ToString() + " / " + Item_Data.Points;
                    t_temp = GameObject.Find("Text_GameGoal_8_Content").GetComponent<Text>();
                    t_temp.text = Learner_Data.Learner_GetData("Mistakes_Num").ToString() + " / " + Item_Data.Mistakes;
                    break;
                case 1: //獎
                    t_temp = GameObject.Find("Text_GameGoal_5_Content").GetComponent<Text>();
                    t_temp.text = Learner_Data.Learner_GetData("Cards_Num").ToString() + " / " + Item_Data.Cards;
                    t_temp = GameObject.Find("Text_GameGoal_6_Content").GetComponent<Text>();
                    t_temp.text = Learner_Data.Learner_GetData("Badges_Num").ToString() + " / " + Item_Data.Badges;
                    break;
                case 2: //懲
                    t_temp = GameObject.Find("Text_GameGoal_5_Content").GetComponent<Text>();
                    t_temp.text = Learner_Data.Learner_GetData("Points_Num").ToString() + " / " + Item_Data.Points;
                    t_temp = GameObject.Find("Text_GameGoal_6_Content").GetComponent<Text>();
                    t_temp.text = Learner_Data.Learner_GetData("Mistakes_Num").ToString() + " / " + Item_Data.Mistakes;
                    break;
                default:
                    break;
            }
        }
        b_temp = GameObject.Find("Button_GameGoals").GetComponent<Button>();
        b_temp.interactable = false;

    }
 
    //GO Button
    public void Task()
    {
        SceneManager.LoadScene("Task");
    }
    public void Learn()
    {
        SceneManager.LoadScene("Learn");
    }
    public void Deck()
    {
        SceneManager.LoadScene("Deck");
    }
    public void Battle()
    {
        SceneManager.LoadScene("Battle");
    }
    public void Shop()
    {
        SceneManager.LoadScene("Shop");
    }
    public void Profile()
    {
        SceneManager.LoadScene("Profile");
    }
    public void Guide()
    {
        SceneManager.LoadScene("Guide");
    }
    public void Badges()
    {
        SceneManager.LoadScene("Badges");
    }
    public void Leaderboard()
    {
        SceneManager.LoadScene("Leaderboard");
    }


}
