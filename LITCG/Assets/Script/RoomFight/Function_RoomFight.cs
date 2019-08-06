using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

static class BattleCheck
{
    //A
    public static string s = ""; //vocabulary
    public static int HandChoose = 0; //選擇的手牌
    public static int Phase = 1; //階段 1:問答 2:出牌 3:戰鬥 4:結算

    //B
}
public class Function_RoomFight : MonoBehaviour {

    private Player_Class Player = new Player_Class();
    private Player_Class Enemy = new Player_Class();
    private Card_Class[] card_temp = new Card_Class[22];

    public void Start()
    {
        Card_Data.Card_Init();
        for (int i = 0; i < 22; i++)
        {
            card_temp[i] = Card_Data.Card_Get(i);
        }
        Player = Player_Data.Player_Get(0);
        Enemy = Player_Data.Player_Get(1);
    }

    public void HA1()
    {
        Image i_temp;
        BattleCheck.HandChoose = 0;
        if (BattleCheck.Phase > 1)
        {
            ShowPicture(Player.GetHand_Status(0));
            i_temp = GameObject.Find("Image_Hand_A_1").GetComponent<Image>();
            i_temp.color = new Color32(255, 0, 0, 255);
        }
        //明天寫點選其他牌的狀況 記得要把顏色歸回全255
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
        Learner_Data.Learner_Add("Battle_Lose", 1);
        Application.LoadLevel("Settlement_Battle");
    }
}
