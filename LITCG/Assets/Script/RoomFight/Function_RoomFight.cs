using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
static class BattleCheck
{
    //A
    public static string s = ""; //vocabulary
    public static int HandChoose = 0; //選擇的手牌
    public static int TypeChoose = 0; //選擇牌的類型 1:戰鬥 2:魔法 3:支援
    public static int Phase = 1; //階段 1:問答 2:出牌 3:戰鬥 4:結算
    public static int Vanguard_A = 22; //22:沒有 0~21:有
    public static int Center_A = 22; //22:沒有 0~21:有
    public static int Support_A = 22; //22:沒有 0~21:有
    public static int A_ATK = 0; //顯示的攻擊力
    //B
    public static int HCB_F = 5; //選擇的手牌 戰鬥卡
    public static int HCB_M = 5; //選擇的手牌 魔法卡
    public static int HCB_S = 5; //選擇的手牌 支援卡

    public static int Vanguard_B = 22; //22:沒有 0~21:有
    public static int Center_B = 22; //22:沒有 0~21:有
    public static int Support_B = 22; //22:沒有 0~21:有
    public static int B_ATK = 0; //顯示的攻擊力

    //win lose
    public static int Flag = 0; //0 = lose  1 = win

}
public class Function_RoomFight : MonoBehaviour {

    private Player_Class Player = new Player_Class();
    private Card_Class[] card_temp = new Card_Class[22];

    int time_int = 2;

    public void Start()
    {
        Card_Data.Card_Init();
        for (int i = 0; i < 22; i++)
        {
            card_temp[i] = Card_Data.Card_Get(i);
        }
        Player = Player_Data.Player_Get(0);
        BattleCheck.HandChoose = 0;
        BattleCheck.TypeChoose = 0;
        BattleCheck.A_ATK = 0;
        BattleCheck.B_ATK = 0;
    }

    public void HA1()
    {
        Image i_temp;
        Reset();
        BattleCheck.HandChoose = 0;
        if (BattleCheck.Phase > 1 && Player.GetHand_Status(0) <22)
        {
            ShowPicture(Player.GetHand_Status(0));
            i_temp = GameObject.Find("Image_Hand_A_1").GetComponent<Image>();
            i_temp.color = new Color32(255, 0, 0, 255);
            CheckUSE(0);
        }
    }
    public void HA2()
    {
        Image i_temp;
        Reset();
        BattleCheck.HandChoose = 1;
        if (BattleCheck.Phase > 1 && Player.GetHand_Status(1) < 22)
        {
            ShowPicture(Player.GetHand_Status(1));
            i_temp = GameObject.Find("Image_Hand_A_2").GetComponent<Image>();
            i_temp.color = new Color32(255, 0, 0, 255);
            CheckUSE(1);
        }
    }
    public void HA3()
    {
        Image i_temp;
        Reset();
        BattleCheck.HandChoose = 2;
        if (BattleCheck.Phase > 1 && Player.GetHand_Status(2) < 22)
        {
            ShowPicture(Player.GetHand_Status(2));
            i_temp = GameObject.Find("Image_Hand_A_3").GetComponent<Image>();
            i_temp.color = new Color32(255, 0, 0, 255);
            CheckUSE(2);
        }
    }
    public void HA4()
    {
        Image i_temp;
        Reset();
        BattleCheck.HandChoose = 3;
        if (BattleCheck.Phase > 1 && Player.GetHand_Status(3) < 22)
        {
            ShowPicture(Player.GetHand_Status(3));
            i_temp = GameObject.Find("Image_Hand_A_4").GetComponent<Image>();
            i_temp.color = new Color32(255, 0, 0, 255);
            CheckUSE(3);
        }
    }
    public void HA5()
    {
        Image i_temp;
        Reset();
        BattleCheck.HandChoose = 4;
        if (BattleCheck.Phase > 1 && Player.GetHand_Status(4) < 22)
        {
            ShowPicture(Player.GetHand_Status(4));
            i_temp = GameObject.Find("Image_Hand_A_5").GetComponent<Image>();
            i_temp.color = new Color32(255, 0, 0, 255);
            CheckUSE(4);
        }
    }

    public void Reset()
    {
        Image i_temp;
        for (int i = 0; i < 5; i++)
        {
            i_temp = GameObject.Find("Image_Hand_A_" + (i+1).ToString()).GetComponent<Image>();
            i_temp.color = new Color32(255, 255, 255, 255);
        }
    }
    public void CheckUSE(int s)
    {
        int n = Player.GetHand_Status(s);
        Button b_temp;

        if (Player.GetHand_Status(s) > 21)
        {
            b_temp = GameObject.Find("Button_USE").GetComponent<Button>();
            b_temp.interactable = false;

            return;
        }

        if (BattleCheck.Vanguard_A == 22 && (card_temp[n].GetCType() == "Vanguard" || card_temp[n].GetCType() == "前衛"))
        {
            b_temp = GameObject.Find("Button_USE").GetComponent<Button>();
            b_temp.interactable = true;
            BattleCheck.TypeChoose = 1;
        }
        else if(BattleCheck.Center_A == 22 && (card_temp[n].GetCType() == "Center" || card_temp[n].GetCType() == "中鋒"))
        {
            b_temp = GameObject.Find("Button_USE").GetComponent<Button>();
            b_temp.interactable = true;
            BattleCheck.TypeChoose = 2;
        }
        else if (BattleCheck.Support_A == 22 && (card_temp[n].GetCType() == "Support" || card_temp[n].GetCType() == "支援"))
        {
            b_temp = GameObject.Find("Button_USE").GetComponent<Button>();
            b_temp.interactable = true;
            BattleCheck.TypeChoose = 3;
        }
        else
        {
            b_temp = GameObject.Find("Button_USE").GetComponent<Button>();
            b_temp.interactable = false;
            BattleCheck.TypeChoose = 0;
        }

    }
    public void ShowPicture(int n)
    {
        Image i_temp;
        Text t_temp;

        i_temp = GameObject.Find("Image_Picture").GetComponent<Image>();
        i_temp.color = new Color32(255, 255, 255, 255);
        i_temp.sprite = Resources.Load("Image/Card/" + card_temp[n].GetPicture(), typeof(Sprite)) as Sprite;

        t_temp = GameObject.Find("Text_CardType").GetComponent<Text>();
        t_temp.text = card_temp[n].GetCType();
        t_temp = GameObject.Find("Text_Effect").GetComponent<Text>();
        t_temp.text = card_temp[n].GetEffect();
    }

    public void Lose()
    {
        Text t_temp;
        Button b_temp;

        t_temp = GameObject.Find("Text_Status").GetComponent<Text>();
        t_temp.text = "遊戲結束!";
        b_temp = GameObject.Find("Button_Surrender").GetComponent<Button>();
        b_temp.interactable = false;

        t_temp = GameObject.Find("Text_Count").GetComponent<Text>();
        t_temp.text = "你輸了!";
        t_temp.color = new Color32(255, 0, 0, 255);
        t_temp.rectTransform.localPosition = new Vector3(-50f, 0f, 0f);

        InvokeRepeating("timer", 1, 1);

    }
    void timer()
    {
        time_int -= 1;


        if (time_int == 0)
        {
            CancelInvoke("timer");
            Learner_Data.Learner_Add("Battle_Lose", 1);
            SceneManager.LoadScene("Settlement_Battle");
        }

    }
}
