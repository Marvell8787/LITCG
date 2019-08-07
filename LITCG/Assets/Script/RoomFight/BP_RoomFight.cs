using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BP_RoomFight : MonoBehaviour {

    private Player_Class Player = new Player_Class();
    private Player_Class Enemy = new Player_Class();
    private Card_Class[] card_temp = new Card_Class[22];
    void Start()
    {
        Card_Data.Card_Init();
        for (int i = 0; i < 22; i++)
        {
            card_temp[i] = Card_Data.Card_Get(i);
        }
    }

    public void START()
    {
        Text t_temp;
        Button b_temp;

        Player = Player_Data.Player_Get(0);
        Enemy = Player_Data.Player_Get(1);

        t_temp = GameObject.Find("Text_Status").GetComponent<Text>();
        t_temp.text = "請出牌!";

        Player_Data.ShowHand(0);

        b_temp = GameObject.Find("Button_START").GetComponent<Button>();
        b_temp.interactable = false;

        BattleCheck.Phase = 2;


    }
    public void USE()
    {
        Button b_temp;
        b_temp = GameObject.Find("Button_USE").GetComponent<Button>();
        b_temp.interactable = false;

        Player = Player_Data.Player_Get(0);


        //BattleCheck.HandChoose = 0;
        Image i_temp;

        if (BattleCheck.TypeChoose == 1)
        {
            i_temp = GameObject.Find("Image_Fight_A").GetComponent<Image>();
            BattleCheck.Fight_A = Player.GetHand_Status(BattleCheck.HandChoose);
        }
        else if(BattleCheck.TypeChoose == 2)
        {
            i_temp = GameObject.Find("Image_Magic_A").GetComponent<Image>();
            BattleCheck.Magic_A = Player.GetHand_Status(BattleCheck.HandChoose);

        }
        else if (BattleCheck.TypeChoose == 3)
        {
            i_temp = GameObject.Find("Image_Support_A").GetComponent<Image>();
            BattleCheck.Support_A = Player.GetHand_Status(BattleCheck.HandChoose);
        }
        else
        {
            i_temp = GameObject.Find("").GetComponent<Image>();
        }
        //Debug.Log(card_temp[Player.GetHand_Status(BattleCheck.HandChoose)].GetPicture());

        i_temp.sprite = Resources.Load("Image/Card/" + card_temp[Player.GetHand_Status(BattleCheck.HandChoose)].GetPicture(), typeof(Sprite)) as Sprite;
        i_temp = GameObject.Find("Image_Hand_A_" + (BattleCheck.HandChoose+1).ToString()).GetComponent<Image>();
        i_temp.sprite = Resources.Load("Image/Battle/Hand", typeof(Sprite)) as Sprite;
        i_temp.color = new Color32(255, 255, 255, 255);

        b_temp = GameObject.Find("Button_FIGHT").GetComponent<Button>();
        b_temp.interactable = true;

        Player.ChangeHand_Status(BattleCheck.HandChoose, 22);
    }
    public void FIGHT()
    {
        BattleCheck.Phase = 3;
        //描述電腦出牌 先出支援 再出魔法 最後出戰鬥(隨機挑)
        
    }
}
