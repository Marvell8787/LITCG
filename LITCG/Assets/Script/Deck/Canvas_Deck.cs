using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Canvas_Deck : MonoBehaviour {

    // Use this for initialization
    void Start() {
        Text t_temp;
        Image i_temp;
        Card_Class[] card_temp = new Card_Class[22];
        int[] card_status = new int[22];

        for (int i = 0; i < 22; i++)
        {
            card_temp[i] = Card_Data.Card_Get(i);
            card_status[i] = Learner_Data.Learner_GetCard_Status(i);
        }

        for (int i = 0; i < 22; i++)
        {
            if (card_status[i] >= 1)
            {
                i_temp = GameObject.Find("Image_Card_" + i.ToString()).GetComponent<Image>();
                i_temp.sprite = Resources.Load("Image/Card/" + card_temp[i].GetPicture(), typeof(Sprite)) as Sprite;
            }
        }

        t_temp = GameObject.Find("Text_Description").GetComponent<Text>();
        t_temp.text = "";
        t_temp = GameObject.Find("Text_No").GetComponent<Text>();
        t_temp.text = "";
    }
}
