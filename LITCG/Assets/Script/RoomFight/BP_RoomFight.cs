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
        BattleCheck.Vanguard_A = 22; //22:沒有 0~21:有
        BattleCheck.Center_A = 22; //22:沒有 0~21:有
        BattleCheck.Support_A = 22; //22:沒有 0~21:有
        BattleCheck.Vanguard_B = 22; //22:沒有 0~21:有
        BattleCheck.Center_B = 22; //22:沒有 0~21:有
        BattleCheck.Support_B = 22; //22:沒有 0~21:有
        BattleCheck.TypeChoose = 0;
        Card_Data.Card_Init();
        for (int i = 0; i < 22; i++)
        {
            card_temp[i] = Card_Data.Card_Get(i);
        }
        BattleCheck.A_ATK = 0;
        BattleCheck.B_ATK = 0;
        Player = Player_Data.Player_Get(0);
        Enemy = Player_Data.Player_Get(1);
    }

    public void START()
    {
        Text t_temp;
        Button b_temp;

        BattleCheck.A_ATK = 0;
        BattleCheck.B_ATK = 0;


        t_temp = GameObject.Find("Text_Count").GetComponent<Text>();
        t_temp.color = new Color32(255, 255, 255, 255);
        t_temp.text = "";
        t_temp.rectTransform.localPosition = new Vector3(-50f, 350f, 0f);


        switch (System_Data.language)
        {
            case 0:
                t_temp = GameObject.Find("Text_Status").GetComponent<Text>();
                t_temp.text = "請出牌!";
                break;
            case 1:
                t_temp = GameObject.Find("Text_Status").GetComponent<Text>();
                t_temp.text = "Use your Card !";
                break;
            default:
                break;
        }



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

        n = Player.GetHand_Status(BattleCheck.HandChoose);

        if (BattleCheck.TypeChoose == 1)
        {
            i_temp = GameObject.Find("Image_Vanguard_A").GetComponent<Image>();
            BattleCheck.Vanguard_A = n;
            t_temp = GameObject.Find("Text_ATK_A_num").GetComponent<Text>();
            t_temp.text = (card_temp[n].GetATK())+" ";
            BattleCheck.A_ATK = card_temp[n].GetATK();
            if (BattleCheck.Center_A < 22)
            {
                int s = BattleCheck.Center_A;
                switch (s)
                {
                    case 15:
                        t_temp.text += "+ " + (card_temp[s].GetATK());
                        BattleCheck.A_ATK += 1;
                        break;
                    case 16:
                        t_temp.text += "+ " + (card_temp[s].GetATK());
                        BattleCheck.A_ATK += 2;
                        break;
                    case 17:
                        t_temp.text = (card_temp[s].GetATK()).ToString();
                        BattleCheck.A_ATK += 3;
                        break;
                    case 18:
                        t_temp.text = (card_temp[s].GetATK()).ToString();
                        BattleCheck.A_ATK += 4;
                        break;
                    default:
                        break;
                }
            }
        }
        else if(BattleCheck.TypeChoose == 2)
        {
            i_temp = GameObject.Find("Image_Center_A").GetComponent<Image>();
            BattleCheck.Center_A = n;
            t_temp = GameObject.Find("Text_ATK_A_num").GetComponent<Text>();
            switch (n)
            {
                case 15:
                    t_temp.text += "+ " + (card_temp[n].GetATK());
                    BattleCheck.A_ATK += 1;
                    break;
                case 16:
                    t_temp.text += "+ " + (card_temp[n].GetATK());
                    BattleCheck.A_ATK += 2;
                    break;
                case 17:
                    t_temp.text = (card_temp[n].GetATK()).ToString();
                    BattleCheck.A_ATK += 3;
                    break;
                case 18:
                    t_temp.text = (card_temp[n].GetATK()).ToString();
                    BattleCheck.A_ATK += 4;
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

        Player.ChangeHand_Status(BattleCheck.HandChoose, 22);

        b_temp = GameObject.Find("Button_FIGHT").GetComponent<Button>();
        b_temp.interactable = true;
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

        Player_Data.ShowHand(0);
        Player_Data.ShowHand(1);
        b_temp = GameObject.Find("Button_USE").GetComponent<Button>();
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
                    Enemy.ChangeHand_Status(Ehand[i], 22);
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
            if (n>14 && n < 18 && BattleCheck.Center_B == 22)
            {
                int r = Random.Range(0, 2);
                if (r == 1)
                {
                    BattleCheck.Center_B = Enemy.GetHand_Status(Ehand[i]); //使用了魔法卡
                    Enemy.ChangeHand_Status(Ehand[i], 22);
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
            if (n < 15 && BattleCheck.Vanguard_B == 22)
            {
                BattleCheck.Vanguard_B = Enemy.GetHand_Status(Ehand[i]); //使用了戰鬥卡
                int a = Enemy.GetHand_Status(Ehand[i]);
                BattleCheck.B_ATK = card_temp[a].GetATK();
                Text temp;
                temp = GameObject.Find("Text_ATK_B_num").GetComponent<Text>();
                temp.text = BattleCheck.B_ATK.ToString();
                BattleCheck.HCB_F = Ehand[i];
                Enemy.ChangeHand_Status(Ehand[i], 22);
                break;
            }
            else
                continue;
        }
        /*
        //Debug
        Player_Data.ShowHand(1);
        string ss="";
        for(int i = 0; i < 5; i++)
        {
            ss += Ehand[i] + " ";
        }
        Debug.Log(ss);
        Debug.Log(BattleCheck.Vanguard_B);
        Debug.Log(BattleCheck.Center_B);
        Debug.Log(BattleCheck.Support_B);
        //Debug
        */
        //電腦放置卡牌

        if (BattleCheck.Vanguard_B < 15)
        {
            
            i_temp = GameObject.Find("Image_Vanguard_B").GetComponent<Image>();
            t_temp = GameObject.Find("Text_ATK_B_num").GetComponent<Text>();
            t_temp.text = (card_temp[BattleCheck.Vanguard_B].GetATK()) + " ";

            BattleCheck.B_ATK = card_temp[BattleCheck.Vanguard_B].GetATK();

            i_temp.sprite = Resources.Load("Image/Card/" + card_temp[BattleCheck.Vanguard_B].GetPicture(), typeof(Sprite)) as Sprite;
            i_temp = GameObject.Find("Image_Hand_B_" + (BattleCheck.HCB_F + 1).ToString()).GetComponent<Image>();
            i_temp.sprite = Resources.Load("Image/Battle/Hand", typeof(Sprite)) as Sprite;
        }
        if (BattleCheck.Center_B >14 && BattleCheck.Center_B < 19)
        {
            i_temp = GameObject.Find("Image_Center_B").GetComponent<Image>();
            t_temp = GameObject.Find("Text_ATK_B_num").GetComponent<Text>();
            switch (BattleCheck.Center_B)
            {
                case 15:
                    t_temp.text = t_temp.text + " + " + (card_temp[BattleCheck.Center_B].GetATK());
                    BattleCheck.B_ATK += 1;
                    break;
                case 16:
                    t_temp.text = t_temp.text + " + " + (card_temp[BattleCheck.Center_B].GetATK());
                    BattleCheck.B_ATK += 2;
                    break;
                case 17:
                    t_temp.text = (card_temp[BattleCheck.Center_B].GetATK()).ToString();
                    BattleCheck.B_ATK += 3;
                    break;
                case 18:
                    t_temp.text = (card_temp[BattleCheck.Center_B].GetATK()).ToString();
                    BattleCheck.B_ATK += 4;
                    break;
                default:
                    break;
            }
            i_temp.sprite = Resources.Load("Image/Card/" + card_temp[BattleCheck.Center_B].GetPicture(), typeof(Sprite)) as Sprite;
            i_temp = GameObject.Find("Image_Hand_B_" + (BattleCheck.HCB_M + 1).ToString()).GetComponent<Image>();
            i_temp.sprite = Resources.Load("Image/Battle/Hand", typeof(Sprite)) as Sprite;
        }
        if (BattleCheck.Support_B < 22)
        {
            i_temp = GameObject.Find("Image_Supprot_B").GetComponent<Image>();
            i_temp.sprite = Resources.Load("Image/Card/" + card_temp[BattleCheck.Vanguard_B].GetPicture(), typeof(Sprite)) as Sprite;

            i_temp = GameObject.Find("Image_Hand_B_" + (BattleCheck.HCB_S  + 1).ToString()).GetComponent<Image>();
            i_temp.sprite = Resources.Load("Image/Battle/Hand", typeof(Sprite)) as Sprite;
        }

        //結算 左上角顯示這回合贏還是輸
        //雙方攻擊力
        Debug.Log("A = " + BattleCheck.A_ATK);
        Debug.Log("B = " + BattleCheck.B_ATK);
        
        //雙方判斷支援卡
        switch (BattleCheck.Support_A)
        {
            case 19:
                Player.ChangeLP(Player.GetLP() + 2);
                break;
            case 20:
                Player.ChangeLP(Player.GetLP() + 3);
                break;
            case 21:
                Player.ChangeLP(Player.GetLP() + 5);
                break;
            default:
                break;
        }
        switch (BattleCheck.Support_B)
        {
            case 19:
                Enemy.ChangeLP(Enemy.GetLP() + 2);
                break;
            case 20:
                Enemy.ChangeLP(Enemy.GetLP() + 3);
                break;
            case 21:
                Enemy.ChangeLP(Enemy.GetLP() + 5);
                break;
            default:
                break;
        }
        int aatk, batk;
        aatk = BattleCheck.A_ATK;
        batk = BattleCheck.B_ATK;
        //判斷攻擊力並分出勝負
        if (aatk > batk)
        {
            Enemy.DecLP((aatk - batk));
            t_temp = GameObject.Find("Text_Status").GetComponent<Text>();
            switch (System_Data.language)
            {
                case 0:
                    t_temp.text = "敵方LP - " + (aatk - batk);
                    break;
                case 1:
                    t_temp.text = "Com LP - " + (aatk - batk);

                    break;
                default:
                    break;
            }
        }
        else if (batk > aatk)
        {
            Player.DecLP((batk - aatk));
            t_temp = GameObject.Find("Text_Status").GetComponent<Text>();
            switch (System_Data.language)
            {
                case 0:
                    t_temp.text = "我方LP - " + (batk - aatk);
                    break;
                case 1:
                    t_temp.text = "Player LP - " + (batk - aatk);
                    break;
                default:
                    break;
            }
        }
        else
        {
            t_temp = GameObject.Find("Text_Status").GetComponent<Text>();
            switch (System_Data.language)
            {
                case 0:
                    t_temp.text = "平手";
                    break;
                case 1:
                    t_temp.text = "It;s tie";
                    break;
                default:
                    break;
            }
        }
        t_temp = GameObject.Find("Text_LP_A_num").GetComponent<Text>();
        t_temp.text = Player.GetLP().ToString();
        t_temp = GameObject.Find("Text_LP_B_num").GetComponent<Text>();
        t_temp.text = Enemy.GetLP().ToString();

        if (Player.GetLP() < 1)
        {
            switch (System_Data.language)
            {
                case 0:
                    b_temp = GameObject.Find("Button_NEXT").GetComponent<Button>();
                    b_temp.GetComponentInChildren<Text>().text = "結束";
                    t_temp = GameObject.Find("Text_Status").GetComponent<Text>();
                    t_temp.text = "遊戲結束!";
                    t_temp = GameObject.Find("Text_Count").GetComponent<Text>();
                    t_temp.text = "你輸了!";
                    break;
                case 1:
                    b_temp = GameObject.Find("Button_NEXT").GetComponent<Button>();
                    b_temp.GetComponentInChildren<Text>().text = "END";
                    t_temp = GameObject.Find("Text_Status").GetComponent<Text>();
                    t_temp.text = "Game Over !";
                    t_temp = GameObject.Find("Text_Count").GetComponent<Text>();
                    t_temp.text = "You Lose !";
                    break;
                default:
                    break;
            }

            t_temp.color = new Color32(255, 0, 0, 255);
            t_temp.rectTransform.localPosition = new Vector3(-50f, 0f, 0f);
        }
        else if (Enemy.GetLP() < 1)
        {
            switch (System_Data.language)
            {
                case 0:
                    b_temp = GameObject.Find("Button_NEXT").GetComponent<Button>();
                    b_temp.GetComponentInChildren<Text>().text = "結束";
                    t_temp = GameObject.Find("Text_Status").GetComponent<Text>();
                    t_temp.text = "遊戲結束!";
                    t_temp = GameObject.Find("Text_Count").GetComponent<Text>();
                    t_temp.text = "你贏了!";
                    break;
                case 1:
                    b_temp = GameObject.Find("Button_NEXT").GetComponent<Button>();
                    b_temp.GetComponentInChildren<Text>().text = "END";
                    t_temp = GameObject.Find("Text_Status").GetComponent<Text>();
                    t_temp.text = "Game Over !";
                    t_temp = GameObject.Find("Text_Count").GetComponent<Text>();
                    t_temp.text = "You Win !";
                    break;
                default:
                    break;
            }

            t_temp.color = new Color32(255, 0, 0, 255);
            t_temp.rectTransform.localPosition = new Vector3(-50f, 0f, 0f);
        }
        else if(BQuestion_Check.Question_Num == BQuestion_Check.Question_total) 
        {
            if(Player.GetLP() >= Enemy.GetLP()){
                switch (System_Data.language)
                {
                    case 0:
                        b_temp = GameObject.Find("Button_NEXT").GetComponent<Button>();
                        b_temp.GetComponentInChildren<Text>().text = "結束";
                        t_temp = GameObject.Find("Text_Status").GetComponent<Text>();
                        t_temp.text = "遊戲結束!";
                        t_temp = GameObject.Find("Text_Count").GetComponent<Text>();
                        t_temp.text = "你贏了!";
                        break;
                    case 1:
                        b_temp = GameObject.Find("Button_NEXT").GetComponent<Button>();
                        b_temp.GetComponentInChildren<Text>().text = "END";
                        t_temp = GameObject.Find("Text_Status").GetComponent<Text>();
                        t_temp.text = "Game Over !";
                        t_temp = GameObject.Find("Text_Count").GetComponent<Text>();
                        t_temp.text = "You Win !";
                        break;
                    default:
                        break;
                }
                t_temp.color = new Color32(255, 0, 0, 255);
                t_temp.rectTransform.localPosition = new Vector3(-50f, 0f, 0f);
            }
            else
            {
                switch (System_Data.language)
                {
                    case 0:
                        b_temp = GameObject.Find("Button_NEXT").GetComponent<Button>();
                        b_temp.GetComponentInChildren<Text>().text = "結束";
                        t_temp = GameObject.Find("Text_Status").GetComponent<Text>();
                        t_temp.text = "遊戲結束!";
                        t_temp = GameObject.Find("Text_Count").GetComponent<Text>();
                        t_temp.text = "你輸了!";
                        break;
                    case 1:
                        b_temp = GameObject.Find("Button_NEXT").GetComponent<Button>();
                        b_temp.GetComponentInChildren<Text>().text = "END";
                        t_temp = GameObject.Find("Text_Status").GetComponent<Text>();
                        t_temp.text = "Game Over !";
                        t_temp = GameObject.Find("Text_Count").GetComponent<Text>();
                        t_temp.text = "You Lose !";
                        break;
                    default:
                        break;
                }
                t_temp.color = new Color32(255, 0, 0, 255);
                t_temp.rectTransform.localPosition = new Vector3(-50f, 0f, 0f);
            }
        }
        else if (Player.GetDeck_Num() == 0)
        {
            switch (System_Data.language)
            {
                case 0:
                    b_temp = GameObject.Find("Button_NEXT").GetComponent<Button>();
                    b_temp.GetComponentInChildren<Text>().text = "結束";
                    t_temp = GameObject.Find("Text_Status").GetComponent<Text>();
                    t_temp.text = "遊戲結束 !";
                    t_temp = GameObject.Find("Text_Count").GetComponent<Text>();
                    t_temp.text = "我方牌組已抽完，你輸了 !";
                    break;
                case 1:
                    b_temp = GameObject.Find("Button_NEXT").GetComponent<Button>();
                    b_temp.GetComponentInChildren<Text>().text = "END";
                    t_temp = GameObject.Find("Text_Status").GetComponent<Text>();
                    t_temp.text = "Game Over !";
                    t_temp = GameObject.Find("Text_Count").GetComponent<Text>();
                    t_temp.text = "Player's Deck is gone !";
                    break;
                default:
                    break;
            }
            t_temp.color = new Color32(255, 0, 0, 255);
            t_temp.rectTransform.localPosition = new Vector3(-50f, 0f, 0f);
        }
        else if (Enemy.GetDeck_Num() == 0)
        {
            switch (System_Data.language)
            {
                case 0:
                    b_temp = GameObject.Find("Button_NEXT").GetComponent<Button>();
                    b_temp.GetComponentInChildren<Text>().text = "結束";
                    t_temp = GameObject.Find("Text_Status").GetComponent<Text>();
                    t_temp.text = "遊戲結束 !";
                    t_temp = GameObject.Find("Text_Count").GetComponent<Text>();
                    t_temp.text = "敵方牌組已抽完，你贏了!";
                    break;
                case 1:
                    b_temp = GameObject.Find("Button_NEXT").GetComponent<Button>();
                    b_temp.GetComponentInChildren<Text>().text = "END";
                    t_temp = GameObject.Find("Text_Status").GetComponent<Text>();
                    t_temp.text = "Game Over !";
                    t_temp = GameObject.Find("Text_Count").GetComponent<Text>();
                    t_temp.text = "Com's Deck is gone !";
                    break;
                default:
                    break;
            }
            t_temp.color = new Color32(255, 0, 0, 255);
            t_temp.rectTransform.localPosition = new Vector3(-50f, 0f, 0f);
        }

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
