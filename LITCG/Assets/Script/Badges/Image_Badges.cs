using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Image_Badges : MonoBehaviour {
    public void Badges_Output(int n)
    {
        Text t_temp;

        t_temp = GameObject.Find("Text_Description").GetComponent<Text>();
        switch (System_Data.language)
        {
            case 0:
                t_temp.text = Badges_Bank.C_Badges_Description[n];
                break;
            case 1:
                t_temp.text = Badges_Bank.E_Badges_Description[n];
                break;
            default:
                break;
        }
    }
    public void Badges_0()
    {
        BadgesCheck.No = 0 + BadgesCheck.Next;
        Badges_Output(BadgesCheck.No);
    }
    public void Badges_1()
    {
        BadgesCheck.No = 1 + BadgesCheck.Next;
        Badges_Output(BadgesCheck.No);
    }
    public void Badges_2()
    {
        BadgesCheck.No = 2 + BadgesCheck.Next;
        Badges_Output(BadgesCheck.No);
    }
    public void Badges_3()
    {
        BadgesCheck.No = 3 + BadgesCheck.Next;
        Badges_Output(BadgesCheck.No);
    }
    public void Badges_4()
    {
        BadgesCheck.No = 4 + BadgesCheck.Next;
        Badges_Output(BadgesCheck.No);
    }
    public void Badges_5()
    {
        BadgesCheck.No = 5 + BadgesCheck.Next;
        Badges_Output(BadgesCheck.No);
    }
    public void Badges_6()
    {
        BadgesCheck.No = 6 + BadgesCheck.Next;
        Badges_Output(BadgesCheck.No);
    }
    public void Badges_7()
    {
        BadgesCheck.No = 7 + BadgesCheck.Next;
        Badges_Output(BadgesCheck.No);
    }
    public void Badges_8()
    {
        BadgesCheck.No = 8 + BadgesCheck.Next;
        Badges_Output(BadgesCheck.No);
    }

}
