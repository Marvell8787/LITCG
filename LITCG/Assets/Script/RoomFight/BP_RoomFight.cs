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
        BattleCheck.Fight_A = 22; //22:沒有 0~21:有
        BattleCheck.Magic_A = 22; //22:沒有 0~21:有
        BattleCheck.Support_A = 22; //22:沒有 0~21:有
        BattleCheck.Fight_B = 22; //22:沒有 0~21:有
        BattleCheck.Magic_B = 22; //22:沒有 0~21:有
        BattleCheck.Support_B = 22; //22:沒有 0~21:有
        BattleCheck.TypeChoose = 0;
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
        Image i_temp;
        Text t_temp;
        int n;

        b_temp = GameObject.Find("Button_USE").GetComponent<Button>();
        b_temp.interactable = false;

        Player = Player_Data.Player_Get(0);
        n = Player.GetHand_Status(BattleCheck.HandChoose);

        if (BattleCheck.TypeChoose == 1)
        {
            i_temp = GameObject.Find("Image_Fight_A").GetComponent<Image>();
            BattleCheck.Fight_A = n;
            t_temp = GameObject.Find("Text_ATK_A_num").GetComponent<Text>();
            t_temp.text = (card_temp[n].GetATK())+" ";
            if (BattleCheck.Magic_A < 22)
            {
                int s = BattleCheck.Magic_A;
                switch (s)
                {
                    case 15:
                        t_temp.text += "+ " + (card_temp[s].GetATK());
                        break;
                    case 16:
                        t_temp.text += "+ " + (card_temp[s].GetATK());
                        break;
                    case 17:
                        t_temp.text = (card_temp[s].GetATK()).ToString();
                        break;
                    default:
                        break;
                }
            }
        }
        else if(BattleCheck.TypeChoose == 2)
        {
            i_temp = GameObject.Find("Image_Magic_A").GetComponent<Image>();
            BattleCheck.Magic_A = n;
            t_temp = GameObject.Find("Text_ATK_A_num").GetComponent<Text>();
            switch (n)
            {
                case 14:
                    t_temp.text += " + " + (card_temp[n].GetATK());
                    break;
                case 15:
                    t_temp.text += " + " + (card_temp[n].GetATK());
                    break;
                case 16:
                    t_temp.text = (card_temp[n].GetATK()).ToString();
                    break;
                default:
                    break;
            }
        }
        else if (BattleCheck.TypeChoose == 3)
        {
            i_temp = GameObject.Find("Image_Support_A").GetComponent<Image>();
            BattleCheck.Support_A = n;
        }
        else
        {
            i_temp = GameObject.Find("").GetComponent<Image>();
        }
        //Debug.Log(card_temp[Player.GetHand_Status(BattleCheck.HandChoose)].GetPicture());

        i_temp.sprite = Resources.Load("Image/Card/" + card_temp[n].GetPicture(), typeof(Sprite)) as Sprite;
        i_temp = GameObject.Find("Image_Hand_A_" + (BattleCheck.HandChoose+1).ToString()).GetComponent<Image>();
        i_temp.sprite = Resources.Load("Image/Battle/Hand", typeof(Sprite)) as Sprite;
        i_temp.color = new Color32(255, 255, 255, 255);

        b_temp = GameObject.Find("Button_FIGHT").GetComponent<Button>();
        b_temp.interactable = true;

        Player.ChangeHand_Status(BattleCheck.HandChoose, 22);
    }
    public void FIGHT()
    {
        Button b_temp;
        Image i_temp;
        Text t_temp;

        BattleCheck.Phase = 3;
        BattleCheck.TypeChoose = 0;
        BattleCheck.HandChoose = 0;

        b_temp = GameObject.Find("Button_FIGHT").GetComponent<Button>();
        b_temp.interactable = false;
        
        //描述電腦出牌 先出支援 再出魔法 最後出戰鬥(隨機挑)

        Enemy = Player_Data.Player_Get(1);

        int[] Ehand = new int[5];
        Ehand = GetRandomSequence(5);
        //亂數決定要不要使用支援卡
        for (int i = 0; i < 5; i++)
        {
            int n=Enemy.GetHand_Status(Ehand[i]);
            if (n > 18 && BattleCheck.Support_B == 22)
            {
                int r = Random.Range(0, 2);
                if (r == 1)
                {
                    BattleCheck.Support_B = Enemy.GetHand_Status(Ehand[i]); //使用了支援卡
                    BattleCheck.HCB_S = Ehand[i];
                    break;
                }
                else
                    continue;
            }
            else
                continue;
        }
        //亂數決定要不要使用魔法卡
        for (int i = 0; i < 5; i++)
        {
            int n = Enemy.GetHand_Status(Ehand[i]);
            if (n>14 && n < 18 && BattleCheck.Magic_B == 22)
            {
                int r = Random.Range(0, 2);
                if (r == 1)
                {
                    BattleCheck.Magic_B = Enemy.GetHand_Status(Ehand[i]); //使用了魔法卡
                    BattleCheck.HCB_M = Ehand[i];
                    break;
                }
                else
                    continue;
            }
            else
                continue;
        }
        //亂數決定要不要使用戰鬥卡
        for (int i = 0; i < 5; i++)
        {
            int n = Enemy.GetHand_Status(Ehand[i]);
            if (n < 15 && BattleCheck.Fight_B == 22)
            {
                BattleCheck.Fight_B = Enemy.GetHand_Status(Ehand[i]); //使用了戰鬥卡
                int a = Enemy.GetHand_Status(Ehand[i]);
                BattleCheck.B_ATK = card_temp[a].GetATK();
                Text temp;
                temp = GameObject.Find("Text_ATK_B_num").GetComponent<Text>();
                temp.text = BattleCheck.B_ATK.ToString();
                BattleCheck.HCB_F = Ehand[i];
                break;
            }
            else
                continue;
        }
        //Debug
        Player_Data.ShowHand(1);
        string ss="";
        for(int i = 0; i < 5; i++)
        {
            ss += Ehand[i] + " ";
        }
        Debug.Log(ss);
        Debug.Log(BattleCheck.Fight_B);
        Debug.Log(BattleCheck.Magic_B);
        Debug.Log(BattleCheck.Support_B);
        //Debug

        //電腦放置卡牌

        if (BattleCheck.Fight_B < 15)
        {
            
            i_temp = GameObject.Find("Image_Fight_B").GetComponent<Image>();
            t_temp = GameObject.Find("Text_ATK_B_num").GetComponent<Text>();
            t_temp.text = (card_temp[BattleCheck.Fight_B].GetATK()) + " ";

            i_temp.sprite = Resources.Load("Image/Card/" + card_temp[BattleCheck.Fight_B].GetPicture(), typeof(Sprite)) as Sprite;
            i_temp = GameObject.Find("Image_Hand_B_" + (BattleCheck.HCB_F + 1).ToString()).GetComponent<Image>();
            i_temp.sprite = Resources.Load("Image/Battle/Hand", typeof(Sprite)) as Sprite;
        }
        if (BattleCheck.Magic_B >14 && BattleCheck.Magic_B < 19)
        {
            i_temp = GameObject.Find("Image_Magic_B").GetComponent<Image>();
            t_temp = GameObject.Find("Text_ATK_B_num").GetComponent<Text>();
            switch (BattleCheck.Magic_B)
            {
                case 14:
                    t_temp.text += " + " + (card_temp[BattleCheck.Magic_B].GetATK());
                    break;
                case 15:
                    t_temp.text += " + " + (card_temp[BattleCheck.Magic_B].GetATK());
                    break;
                case 16:
                    t_temp.text = (card_temp[BattleCheck.Magic_B].GetATK()).ToString();
                    break;
                default:
                    break;
            }
            i_temp.sprite = Resources.Load("Image/Card/" + card_temp[BattleCheck.Magic_B].GetPicture(), typeof(Sprite)) as Sprite;
            i_temp = GameObject.Find("Image_Hand_B_" + (BattleCheck.HCB_M + 1).ToString()).GetComponent<Image>();
            i_temp.sprite = Resources.Load("Image/Battle/Hand", typeof(Sprite)) as Sprite;
        }
        if (BattleCheck.Support_B < 22)
        {
            i_temp = GameObject.Find("Image_Supprot_B").GetComponent<Image>();
            i_temp.sprite = Resources.Load("Image/Card/" + card_temp[BattleCheck.Fight_B].GetPicture(), typeof(Sprite)) as Sprite;

            i_temp = GameObject.Find("Image_Hand_B_" + (BattleCheck.HCB_S  + 1).ToString()).GetComponent<Image>();
            i_temp.sprite = Resources.Load("Image/Battle/Hand", typeof(Sprite)) as Sprite;
        }

        //結算 左上角顯示這回合贏還是輸


        t_temp = GameObject.Find("Text_Status").GetComponent<Text>();
        t_temp.text = "你贏了"; //或你輸了

        //開啟 NEXT按鈕
        b_temp = GameObject.Find("Button_NEXT").GetComponent<Button>();
        b_temp.interactable = true;

    }

    public static int[] GetRandomSequence(int total)
    {
        int r;
        int[] output = new int[total];
        for (int i = 0; i < total; i++)
        {
            output[i] = i;
        }
        for (int i = 0; i < total; i++)
        {
            r = Random.Range(0, total);
            int temp = 0;
            temp = output[i];
            output[i] = output[r];
            output[r] = temp;
        }
        return output;
    }
}
