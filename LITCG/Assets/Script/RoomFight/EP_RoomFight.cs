using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EP_RoomFight : MonoBehaviour {
    private Player_Class Player = new Player_Class();
    private Player_Class Enemy = new Player_Class();
    private Card_Class[] card_temp = new Card_Class[22];
    // Use this for initialization
    void Start () {
        Card_Data.Card_Init();
        for (int i = 0; i < 22; i++)
        {
            card_temp[i] = Card_Data.Card_Get(i);
        }

    }
	
	public void NEXT()
    {
        Button b_temp;
        Image i_temp;
        Text t_temp;
        //先判斷遊戲是否結束 是:進入結算畫面 否:重整盤面 抽牌  進入QP

        Player = Player_Data.Player_Get(0);
        Enemy = Player_Data.Player_Get(1);

        if (Player.GetLP() < 1)
        {
            Learner_Data.Learner_Add("Battle_Lose", 1);
            Application.LoadLevel("Settlement_Battle");
        }
        else if (Enemy.GetLP() < 1)
        {
            Learner_Data.Learner_Add("Battle_Win", 1);
            Application.LoadLevel("Settlement_Battle");
        }
        else if (Player.GetDeck_Num() ==0)
        {
            Learner_Data.Learner_Add("Battle_Lose", 1);
            Application.LoadLevel("Settlement_Battle");
        }
        else if (Enemy.GetDeck_Num() == 0)
        {
            Learner_Data.Learner_Add("Battle_Win", 1);
            Application.LoadLevel("Settlement_Battle");
        }
        else
        {
            b_temp = GameObject.Find("Button_NEXT").GetComponent<Button>();
            b_temp.interactable = false;

            //重整
            BattleCheck.Phase = 1; //問答階段
            BattleCheck.A_ATK = 0;
            BattleCheck.B_ATK = 0;
            BattleCheck.HandChoose = 0;
            BattleCheck.TypeChoose = 0;
            BattleCheck.Fight_A = 22; //22:沒有 0~21:有
            BattleCheck.Magic_A = 22; //22:沒有 0~21:有
            BattleCheck.Support_A = 22; //22:沒有 0~21:有
            BattleCheck.HCB_F = 5;
            BattleCheck.HCB_M = 5;
            BattleCheck.HCB_S = 5;
            BattleCheck.Fight_B = 22; //22:沒有 0~21:有
            BattleCheck.Magic_B = 22; //22:沒有 0~21:有
            BattleCheck.Support_B = 22; //22:沒有 0~21:有

            i_temp = GameObject.Find("Image_Fight_A").GetComponent<Image>();
            i_temp.sprite = Resources.Load("Image/Battle/Table", typeof(Sprite)) as Sprite;
            i_temp = GameObject.Find("Image_Magic_A").GetComponent<Image>();
            i_temp.sprite = Resources.Load("Image/Battle/Table", typeof(Sprite)) as Sprite;
            i_temp = GameObject.Find("Image_Support_A").GetComponent<Image>();
            i_temp.sprite = Resources.Load("Image/Battle/Table", typeof(Sprite)) as Sprite;
            i_temp = GameObject.Find("Image_Fight_B").GetComponent<Image>();
            i_temp.sprite = Resources.Load("Image/Battle/Table", typeof(Sprite)) as Sprite;
            i_temp = GameObject.Find("Image_Magic_B").GetComponent<Image>();
            i_temp.sprite = Resources.Load("Image/Battle/Table", typeof(Sprite)) as Sprite;
            i_temp = GameObject.Find("Image_Support_B").GetComponent<Image>();
            i_temp.sprite = Resources.Load("Image/Battle/Table", typeof(Sprite)) as Sprite;
            t_temp = GameObject.Find("Text_ATK_A_num").GetComponent<Text>();
            t_temp.text = "0";
            t_temp = GameObject.Find("Text_ATK_B_num").GetComponent<Text>();
            t_temp.text = "0";

            t_temp = GameObject.Find("Text_Status").GetComponent<Text>();
            t_temp.text = "請答題!";

            //抽牌

            Player_Data.Draw(0, 1); //玩家抽1
            Player_Data.Draw(1, 1); //電腦抽1
            t_temp = GameObject.Find("Text_Deck_A_num").GetComponent<Text>();
            t_temp.text = (Player.GetDeck_Num()).ToString();
            t_temp = GameObject.Find("Text_Deck_B_num").GetComponent<Text>();
            t_temp.text = (Enemy.GetDeck_Num()).ToString();

            Player_Data.ShowHand(0);
            Player_Data.ShowHand(1);


            //問題設置
            BQuestion_Class question_temp = new BQuestion_Class();

            question_temp = BQuestion_Data.BQuestion_Get(BQuestion_Check.Question_Num);
            t_temp = GameObject.Find("Text_Q_Num").GetComponent<Text>();
            t_temp.text = (BQuestion_Check.Question_Num + 1).ToString() + ".";
            t_temp = GameObject.Find("Text_Q").GetComponent<Text>();
            t_temp.text = question_temp.GetQuestion();
            BQuestion_Data.Button_Ans_Set();

            b_temp = GameObject.Find("Button_Ans_1").GetComponent<Button>();
            b_temp.interactable = true;
            b_temp = GameObject.Find("Button_Ans_2").GetComponent<Button>();
            b_temp.interactable = true;
            b_temp = GameObject.Find("Button_Ans_3").GetComponent<Button>();
            b_temp.interactable = true;
        }

    }
}
