using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Canvas_Badges : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Button b_temp;
        Text t_temp;
        switch (System_Data.language)
        {
            case 0:
                b_temp = GameObject.Find("Button_Back").GetComponent<Button>();
                b_temp.GetComponentInChildren<Text>().text = "返回";
                t_temp = GameObject.Find("Text_Copper").GetComponent<Text>();
                t_temp.text = "銅";
                t_temp = GameObject.Find("Text_Silver").GetComponent<Text>();
                t_temp.text = "銀";
                t_temp = GameObject.Find("Text_Gold").GetComponent<Text>();
                t_temp.text = "金";
                t_temp = GameObject.Find("Text_Description").GetComponent<Text>();
                t_temp.text = "點選圖片可查看資訊";
                break;
            case 1:
                break;
            default:
                break;
        }
        for (int i = 0; i < 3; i++)
        {
            t_temp = GameObject.Find("Text_Item_" + i.ToString()).GetComponent<Text>();
            switch (System_Data.language)
            {
                case 0:
                    t_temp.text = Badges_Bank.C_Badges_Name[i + BadgesCheck.Item];
                    break;
                case 1:
                    t_temp.text = Badges_Bank.E_Badges_Name[i + BadgesCheck.Item];
                    break;
                default:
                    break;
            }
        }
        ShowPicture();
    }
	void ShowPicture()
    {
        Image i_temp;
        int[] badges_temp = new int[9];

        for(int i = 0; i < 9; i++)
        {
            badges_temp[i] = Learner_Data.Learner_GetBadges_Status(i);
        }

        for (int i = 0; i < 9; i++)
        {
            if (badges_temp[i] == 1)
            {
                i_temp = GameObject.Find("Image_Badges_" + i.ToString()).GetComponent<Image>();
                i_temp.color = new Color32(255, 255, 255, 255);

            }
            else
            {
                i_temp = GameObject.Find("Image_Badges_" + i.ToString()).GetComponent<Image>();
                i_temp.color = new Color32(60,60,60,255);
            }
        }
    }
}
