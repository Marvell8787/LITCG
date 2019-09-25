using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

static class BadgesCheck
{
    public static int No = 0;
    public static int Item = 0; //0 3
    public static int Next = 0; //0 9

    public static int PageUp = 1;

}

public class Function_Badges : MonoBehaviour {

    public void Previous()
    {
        if (BadgesCheck.PageUp > 1)
        {
            BadgesCheck.PageUp--;
            BadgesCheck.Item = 0;
            BadgesCheck.Next = 0;
            PageChage();
        }

    }
    public void Next()
    {
        if (BadgesCheck.PageUp < 2)
        {
            BadgesCheck.PageUp++;
            BadgesCheck.Item = 3;
            BadgesCheck.Next = 9;
            PageChage();
        }

    }
    public void PageChage()
    {
        Text t_temp;
        t_temp = GameObject.Find("Text_PageUp").GetComponent<Text>();
        t_temp.text = BadgesCheck.PageUp.ToString();
        for(int i = 0; i<3; i++)
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

    public void Back()
    {
        SceneManager.LoadScene("Home");
    }

    void ShowPicture()
    {
        Image i_temp;
        int[] badges_temp = new int[9];

        for (int i = 0; i < 9; i++)
        {
            badges_temp[i] = Learner_Data.Learner_GetBadges_Status(i + BadgesCheck.Next);
        }

        for (int i = 0; i < 9; i++)
        {
            i_temp = GameObject.Find("Image_Badges_" + i.ToString()).GetComponent<Image>();
            if (badges_temp[i] == 1)
                i_temp.color = new Color32(255, 255, 255, 255);
            else
                i_temp.color = new Color32(60, 60, 60, 255);
        }
    }
}
