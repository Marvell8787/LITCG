using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Image_Deck : MonoBehaviour {

    private static Card_Class card_temp = new Card_Class();

    public void Card_0()
    {
        Card_Output(0);
    }
    public void Card_Output(int n)
    {
        card_temp = Card_Data.Card_Get(n);
        Image I_Temp;
        Text T_temp;
        I_Temp = GameObject.Find("Image_Show").GetComponent<Image>();
        I_Temp.sprite = Resources.Load("Image/Card/" + card_temp.GetPicture(), typeof(Sprite)) as Sprite;

        T_temp = GameObject.Find("Text_DescriptionContent").GetComponent<Text>();
        T_temp.text = card_temp.GetEffect();
    }
}
