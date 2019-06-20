using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Image_Badges : MonoBehaviour {
    public void Badges_Output(int n)
    {
        //Image I_Temp;
        Text T_temp;
        //I_Temp = GameObject.Find("Image_Show").GetComponent<Image>();
        //I_Temp.sprite = Resources.Load("Image/Card/" + card_temp.GetPicture(), typeof(Sprite)) as Sprite;

        T_temp = GameObject.Find("Text_Description").GetComponent<Text>();
        T_temp.text = n.ToString();
    }
    public void Badges_0()
    {
        Badges_Output(0);
    }
    public void Badges_1()
    {
        Badges_Output(1);
    }
    public void Badges_2()
    {
        Badges_Output(2);
    }
    public void Badges_3()
    {
        Badges_Output(3);
    }
    public void Badges_4()
    {
        Badges_Output(4);
    }
    public void Badges_5()
    {
        Badges_Output(5);
    }
    public void Badges_6()
    {
        Badges_Output(6);
    }
    public void Badges_7()
    {
        Badges_Output(7);
    }
    public void Badges_8()
    {
        Badges_Output(8);
    }

}
