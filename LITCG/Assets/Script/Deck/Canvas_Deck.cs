using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Canvas_Deck : MonoBehaviour {

    // Use this for initialization
    void Start() {
        Text T_temp;
        Image I_Temp;
        Card_Class[] card_temp = new Card_Class[22];
        int[] card_status = new int[22];

        Card_Data.Card_Init();

        for (int i = 0; i < 22; i++)
        {
            card_temp[i] = Card_Data.Card_Get(i);

            card_status[i] = Learner_Data.Learner_GetCard_Status(i);
        }

        for (int i = 0; i < 22; i++)
        {
            if (card_status[i] == 1)
            {
                I_Temp = GameObject.Find("Image_Card_" + i.ToString()).GetComponent<Image>();
                I_Temp.sprite = Resources.Load("Image/Card/" + card_temp[i].GetPicture(), typeof(Sprite)) as Sprite;
            }
        }

        T_temp = GameObject.Find("Text_DescriptionContent").GetComponent<Text>();
        T_temp.text = "";
    }
}
