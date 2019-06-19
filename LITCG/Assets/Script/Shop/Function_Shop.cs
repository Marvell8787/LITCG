using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Function_Shop : MonoBehaviour {

    public void Crystal1()
    {
        if(Learner_Data.Learner_GetData("Coin") >= 100)
        {
            Learner_Data.Learner_Add("Crystal", 1);
            Learner_Data.Learner_Add("Coin", -100);
            Close(1);
        }
    }
    public void Crystal2()
    {
        if (Learner_Data.Learner_GetData("Coin") >= 100)
        {
            Learner_Data.Learner_Add("Crystal", 1);
            Learner_Data.Learner_Add("Coin", -100);
            Close(2);
        }
    }
    public void Card1()
    {
        if (Learner_Data.Learner_GetData("Coin") >= 150)
        {
            Learner_Data.Learner_Add("Card_Num",1);
            Learner_Data.Learner_ChangeCard_Status(7);
            Learner_Data.Learner_Add("Coin", -150);
            Close(3);
        }
    }
    public void Card2()
    {
        if (Learner_Data.Learner_GetData("Coin") >= 150)
        {
            Learner_Data.Learner_Add("Card_Num", 1);
            Learner_Data.Learner_ChangeCard_Status(8);
            Learner_Data.Learner_Add("Coin", -150);
            Close(4);
        }
    }
    public void Card3()
    {
        if (Learner_Data.Learner_GetData("Coin") >= 150)
        {
            Learner_Data.Learner_Add("Card_Num", 1);
            Learner_Data.Learner_ChangeCard_Status(9);
            Learner_Data.Learner_Add("Coin", -150);
            Close(5);
        }
    }
    public void Card4()
    {
        if (Learner_Data.Learner_GetData("Coin") >= 150)
        {
            Learner_Data.Learner_Add("Card_Num", 1);
            Learner_Data.Learner_ChangeCard_Status(10);
            Learner_Data.Learner_Add("Coin", -150);
            Close(6);
        }
    }
    public void Close(int n)
    {
        Button B_Temp;
        B_Temp = GameObject.Find("Button_Buy_" + n.ToString()).GetComponent<Button>();
        B_Temp.interactable = false;

        Text T_Temp;
        T_Temp = GameObject.Find("Text_CoinContent").GetComponent<Text>();
        T_Temp.text = Learner_Data.Learner_GetData("Coin").ToString();
        Debug.Log("OK");
    }

    public void Back()
    {
        Application.LoadLevel("Home");
    }
}
