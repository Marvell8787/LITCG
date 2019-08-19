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

        b_temp = GameObject.Find("Button_GameGoals").GetComponent<Button>();
        b_temp.interactable = false;

    }
    public void Status()
    {
        Text t_temp;
        Button b_temp;

        t_temp = GameObject.Find("Text_ScoreContent").GetComponent<Text>();
        t_temp.text = Learner_Data.Learner_GetData("Score").ToString();
        t_temp = GameObject.Find("Text_CoinContent").GetComponent<Text>();
        t_temp.text = Learner_Data.Learner_GetData("Coin").ToString();
        t_temp = GameObject.Find("Text_CrystalContent").GetComponent<Text>();
        t_temp.text = Learner_Data.Learner_GetData("Crystal").ToString();
        t_temp = GameObject.Find("Text_CardsContent").GetComponent<Text>();
        t_temp.text = Learner_Data.Learner_GetData("Cards_Num").ToString();
        t_temp = GameObject.Find("Text_BadgesContent").GetComponent<Text>();
        t_temp.text = Learner_Data.Learner_GetData("Badges_Num").ToString();
        t_temp = GameObject.Find("Text_PointsContent").GetComponent<Text>();
        t_temp.text = Learner_Data.Learner_GetData("Points_Num").ToString();
        t_temp = GameObject.Find("Text_MistakesContent").GetComponent<Text>();
        t_temp.text = Learner_Data.Learner_GetData("Mistakes_Num").ToString();

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
