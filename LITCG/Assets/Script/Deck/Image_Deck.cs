using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Image_Deck : MonoBehaviour {

    private static Card_Class card_temp = new Card_Class();

    public void Card_Output(int n)
    {
        Image I_Temp;
        Text T_temp;
        for(int i = 0; i < 22; i++)
        {
            I_Temp = GameObject.Find("Image_Card_" + i).GetComponent<Image>();
            I_Temp.color = new Color32(255, 255, 255, 255);
        }
        I_Temp = GameObject.Find("Image_Card_" + n).GetComponent<Image>();
        I_Temp.color = new Color32(255, 0, 0, 255);

        int card_status = new int();
        card_status = Learner_Data.Learner_GetCard_Status(n);
        if (card_status == 0)
            return;

        card_temp = Card_Data.Card_Get(n);

        I_Temp = GameObject.Find("Image_Show").GetComponent<Image>();
        I_Temp.sprite = Resources.Load("Image/Card/" + card_temp.GetPicture(), typeof(Sprite)) as Sprite;

        T_temp = GameObject.Find("Text_DescriptionContent").GetComponent<Text>();
        T_temp.text = card_temp.GetEffect();
    }
    public void Card_0()
    {
        Card_Output(0);
    }
    public void Card_1()
    {
        Card_Output(1);
    }
    public void Card_2()
    {
        Card_Output(2);
    }
    public void Card_3()
    {
        Card_Output(3);
    }
    public void Card_4()
    {
        Card_Output(4);
    }
    public void Card_5()
    {
        Card_Output(5);
    }
    public void Card_6()
    {
        Card_Output(6);
    }
    public void Card_7()
    {
        Card_Output(7);
    }
    public void Card_8()
    {
        Card_Output(8);
    }
    public void Card_9()
    {
        Card_Output(9);
    }
    public void Card_10()
    {
        Card_Output(10);
    }
    public void Card_11()
    {
        Card_Output(11);
    }
    public void Card_12()
    {
        Card_Output(12);
    }
    public void Card_13()
    {
        Card_Output(13);
    }
    public void Card_14()
    {
        Card_Output(14);
    }
    public void Card_15()
    {
        Card_Output(15);
    }
    public void Card_16()
    {
        Card_Output(16);
    }
    public void Card_17()
    {
        Card_Output(17);
    }
    public void Card_18()
    {
        Card_Output(18);
    }
    public void Card_19()
    {
        Card_Output(19);
    }
    public void Card_20()
    {
        Card_Output(20);
    }
    public void Card_21()
    {
        Card_Output(21);
    }

}
