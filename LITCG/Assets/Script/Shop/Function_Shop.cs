using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Function_Shop : MonoBehaviour {

    public void Card1()
    {
        Button B_Temp;

        if(Learner_Data.Learner_GetData("Coin") >= 100)
        {
            B_Temp = GameObject.Find("Button_Buy_1").GetComponent<Button>();
            B_Temp.interactable = false;
            Learner_Data.Learner_Add("Coin", -100);
        }
        
    }

    public void Back()
    {
        Application.LoadLevel("Home");
    }
}
