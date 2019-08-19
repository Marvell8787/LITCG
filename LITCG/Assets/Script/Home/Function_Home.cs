using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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
    public void Status()
    {
        Text t_temp;
        Button b_temp;
        if (System_Data.Version < 3)
        {
            t_temp = GameObject.Find("Text_ScoreContent").GetComponent<Text>();
            t_temp.text = Learner_Data.Learner_GetData("Score").ToString();
            t_temp = GameObject.Find("Text_CoinContent").GetComponent<Text>();
            t_temp.text = Learner_Data.Learner_GetData("Coin").ToString();
            t_temp = GameObject.Find("Text_CrystalContent").GetComponent<Text>();
            t_temp.text = Learner_Data.Learner_GetData("Crystal").ToString();
            switch (System_Data.Version)
            {
                case 0: //獎懲皆有
                    t_temp = GameObject.Find("Text_CardsContent").GetComponent<Text>();
                    t_temp.text = Learner_Data.Learner_GetData("Cards_Num").ToString();
                    t_temp = GameObject.Find("Text_BadgesContent").GetComponent<Text>();
                    t_temp.text = Learner_Data.Learner_GetData("Badges_Num").ToString();
                    t_temp = GameObject.Find("Text_PointsContent").GetComponent<Text>();
                    t_temp.text = Learner_Data.Learner_GetData("Points_Num").ToString();
                    t_temp = GameObject.Find("Text_MistakesContent").GetComponent<Text>();
                    t_temp.text = Learner_Data.Learner_GetData("Mistakes_Num").ToString();
                    break;
                case 1: //獎
                    t_temp = GameObject.Find("Text_CardsContent").GetComponent<Text>();
                    t_temp.text = Learner_Data.Learner_GetData("Cards_Num").ToString();
                    t_temp = GameObject.Find("Text_BadgesContent").GetComponent<Text>();
                    t_temp.text = Learner_Data.Learner_GetData("Badges_Num").ToString();
                    break;
                case 2: //懲
                    t_temp = GameObject.Find("Text_CardsContent").GetComponent<Text>();
                    t_temp.text = Learner_Data.Learner_GetData("Points_Num").ToString();
                    t_temp = GameObject.Find("Text_BadgesContent").GetComponent<Text>();
                    t_temp.text = Learner_Data.Learner_GetData("Mistakes_Num").ToString();
                    break;
                default:
                    break;
            }
        }




        b_temp = GameObject.Find("Button_Status").GetComponent<Button>();
        b_temp.interactable = false;
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
        Application.LoadLevel("Battle");
    }
    public void Shop()
    {
        Application.LoadLevel("Shop");
    }
    public void Profile()
    {
        Application.LoadLevel("Profile");
    }
    public void Guide()
    {
        Application.LoadLevel("Guide");
    }
    public void Badges()
    {
        Application.LoadLevel("Badges");
    }
    public void Leaderboard()
    {
        Application.LoadLevel("Leaderboard");
    }


}
