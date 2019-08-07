using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

static class BattleCheck
{
    //A
    public static string s = ""; //vocabulary
    public static int HandChoose = 0; //選擇的手牌
    public static int TypeChoose = 0; //選擇牌的類型 1:戰鬥 2:魔法 3:支援
    public static int Phase = 1; //階段 1:問答 2:出牌 3:戰鬥 4:結算
    public static int Fight_A = 22; //22:沒有 0~21:有
    public static int Magic_A = 22; //22:沒有 0~21:有
    public static int Support_A = 22; //22:沒有 0~21:有

    //B
}
public class Function_RoomFight : MonoBehaviour {

    private Player_Class Player = new Player_Class();
    private Player_Class Enemy = new Player_Class();
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
        Enemy = Player_Data.Player_Get(1);
        BattleCheck.HandChoose = 0;
        BattleCheck.TypeChoose = 0;
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
        Button b_temp;
        if (Player.GetHand_Status(s) > 21)
        {
            b_temp = GameObject.Find("Button_USE").GetComponent<Button>();
            b_temp.interactable = false;
            //BattleCheck.Fight_A = 22; //0:沒有 1:有
            //BattleCheck.Magic_A = 22; //0:沒有 1:有
            //BattleCheck.Support_A = 22; //0:沒有 1:有
            //BattleCheck.TypeChoose = 0;
            return;
        }

        if (BattleCheck.Fight_A == 22 && card_temp[Player.GetHand_Status(s)].GetCType() == "Fight")
        {
            b_temp = GameObject.Find("Button_USE").GetComponent<Button>();
            b_temp.interactable = true;
            BattleCheck.TypeChoose = 1;
        }
        else if(BattleCheck.Magic_A == 22 && card_temp[Player.GetHand_Status(s)].GetCType() == "Magic")
        {
            b_temp = GameObject.Find("Button_USE").GetComponent<Button>();
            b_temp.interactable = true;
            BattleCheck.TypeChoose = 2;
        }
        else if (BattleCheck.Support_A == 22 && card_temp[Player.GetHand_Status(s)].GetCType() == "Support")
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

	public void Win()
    {
        Learner_Data.Learner_Add("Battle_Win", 1);
        Application.LoadLevel("Settlement_Battle");
    }
    public void Lose()
    {
        Text t_temp;
        Button b_temp;

        t_temp = GameObject.Find("Text_Status").GetComponent<Text>();
        t_temp.text = "你輸了!";
        b_temp = GameObject.Find("Button_Surrender").GetComponent<Button>();
        b_temp.interactable = false;
        InvokeRepeating("timer", 1, 1);

    }
    void timer()
    {

        time_int -= 1;


        if (time_int == 0)
        {
            CancelInvoke("timer");
            Learner_Data.Learner_Add("Battle_Lose", 1);
            Application.LoadLevel("Settlement_Battle");
        }

    }
}
