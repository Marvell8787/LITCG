using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Function_Shop : MonoBehaviour {

    public void Card1()
    {
        Text t_temp;
        if (Learner_Data.Learner_GetData("Coin") >= 150)
        {
            Learner_Data.Learner_Add("Card_Num",1);
            Learner_Data.Learner_ChangeCard_Status(7);
            Learner_Data.Learner_Add("Coin", -150);
            Close(1);
        }
        else
        {
            switch (System_Data.language)
            {
                case 0:
                    t_temp = GameObject.Find("Text_Description").GetComponent<Text>();
                    t_temp.text = "金幣不足";
                    break;
                default:
                    t_temp = GameObject.Find("Text_Description").GetComponent<Text>();
                    t_temp.text = "Your coin are insufficient";
                    break;
            }
        }
    }
    public void Card2()
    {
        Text t_temp;
        if (Learner_Data.Learner_GetData("Coin") >= 150)
        {
            Learner_Data.Learner_Add("Card_Num", 1);
            Learner_Data.Learner_ChangeCard_Status(8);
            Learner_Data.Learner_Add("Coin", -150);
            Close(2);
        }
        else
        {
            switch (System_Data.language)
            {
                case 0:
                    t_temp = GameObject.Find("Text_Description").GetComponent<Text>();
                    t_temp.text = "金幣不足";
                    break;
                default:
                    t_temp = GameObject.Find("Text_Description").GetComponent<Text>();
                    t_temp.text = "Your coin are insufficient";
                    break;
            }
        }
    }
    public void Card3()
    {
        Text t_temp;
        if (Learner_Data.Learner_GetData("Coin") >= 150)
        {
            Learner_Data.Learner_Add("Card_Num", 1);
            Learner_Data.Learner_ChangeCard_Status(9);
            Learner_Data.Learner_Add("Coin", -150);
            Close(3);
        }
        else
        {
            switch (System_Data.language)
            {
                case 0:
                    t_temp = GameObject.Find("Text_Description").GetComponent<Text>();
                    t_temp.text = "金幣不足";
                    break;
                default:
                    t_temp = GameObject.Find("Text_Description").GetComponent<Text>();
                    t_temp.text = "Your coin are insufficient";
                    break;
            }
        }
    }
    public void Card4()
    {
        Text t_temp;
        if (Learner_Data.Learner_GetData("Coin") >= 150)
        {
            Learner_Data.Learner_Add("Card_Num", 1);
            Learner_Data.Learner_ChangeCard_Status(10);
            Learner_Data.Learner_Add("Coin", -150);
            Close(4);
        }
        else
        {
            switch (System_Data.language)
            {
                case 0:
                    t_temp = GameObject.Find("Text_Description").GetComponent<Text>();
                    t_temp.text = "金幣不足";
                    break;
                default:
                    t_temp = GameObject.Find("Text_Description").GetComponent<Text>();
                    t_temp.text = "Your coin are insufficient";
                    break;
            }
        }
    }
    public void Close(int n)
    {
        Button b_temp;
        b_temp = GameObject.Find("Button_Buy_" + n.ToString()).GetComponent<Button>();
        b_temp.interactable = false;

        Text t_temp;
        t_temp = GameObject.Find("Text_CoinContent").GetComponent<Text>();
        t_temp.text = Learner_Data.Learner_GetData("Coin").ToString();
    }

    public void ShowContent()
    {
        Text t_temp;
        t_temp = GameObject.Find("Text_Description").GetComponent<Text>();
        t_temp.text = Learner_Data.Learner_GetData("Coin").ToString();
    }
    public void Back()
    {
        SceneManager.LoadScene("Home");
    }
}
