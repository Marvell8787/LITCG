﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

static class Player_Data{

    private static Player_Class[] Player = new Player_Class[2];  // 0:自己 1:敵人
    private static Card_Class[] card_temp = new Card_Class[22];

    public static void Player_Init()
    {
        Random.InitState(System.Guid.NewGuid().GetHashCode());
        for (int i = 0; i < 22; i++)
        {
            card_temp[i] = Card_Data.Card_Get(i);
        }

        //Debug.Log(Learner_Data.Learner_GetData("Cards_Num").ToString());
        Player[0] = new Player_Class(20, Learner_Data.Learner_GetData("Cards_Num"),0,5); 

        for(int i = 0; i < 22; i++)
        {
            int n;
            n=Learner_Data.Learner_GetCard_Status(i);
            Player[0].ChangeDeck_Status(i,n);
            if(n==1)
                Player[0].ChangeDeck_Fight(i, i);
            else
                Player[0].ChangeDeck_Fight(i, 22);
        }


        switch (Enemy.No)
        {
            case 1:
                Player[1] = new Player_Class(10,14, 0, 5);
                for (int i = 0; i < 22; i++)
                {
                    if (i < 12)
                        Player[1].ChangeDeck_Status(i, 1); //0~11
                    else if(i >14 && i<17)
                        Player[1].ChangeDeck_Status(i, 1); //15 16
                    else
                    {
                        Player[1].ChangeDeck_Status(i, 0); //12~14 17~21
                        Player[1].ChangeDeck_Fight(i, 22);
                        continue;
                    }
                    Player[1].ChangeDeck_Fight(i, i);
                }
                break;
            case 2:
                Player[1] = new Player_Class(15, 17, 0, 5);
                for (int i = 0; i < 22; i++)
                {
                    if (i < 14)
                        Player[1].ChangeDeck_Status(i, 1); //0~13
                    else if (i > 14 && i < 18)
                        Player[1].ChangeDeck_Status(i, 1); //15~17
                    else
                    {
                        Player[1].ChangeDeck_Status(i, 0); //12~14 17~21
                        Player[1].ChangeDeck_Fight(i, 22);
                        continue;
                    }
                    Player[1].ChangeDeck_Fight(i, i);
                }
                break;
            case 3:
                Player[1] = new Player_Class(20, 20, 0, 5);
                for (int i = 0; i < 22; i++)
                {
                    if (i < 18)
                        Player[1].ChangeDeck_Status(i, 1); //0~17
                    else if(i>18 && i<21)
                        Player[1].ChangeDeck_Status(i, 1); //19~20
                    else
                    {
                        Player[1].ChangeDeck_Status(i, 0); //12~14 17~21
                        Player[1].ChangeDeck_Fight(i, 22);
                        continue;
                    }
                    Player[1].ChangeDeck_Fight(i, i);
                }
                break;
            default:
                break;
        }
    }

    public static Player_Class Player_Get(int n)
    {
        return Player[n];
    }
    public static void Deal() //發牌
    {
        //玩家
        int i = 0;
        while (i < 5)
        {
            int n;
            n=Player[0].GetDeck_Fight(Player[0].GetDeck_Draw());
            if (n < 22)
            {
                Player[0].ChangeHand_Status(i, n);
                Player[0].AddDeck_Draw(1);
                i++;
                continue;
            }
            else
            {
                Player[0].AddDeck_Draw(1);
                continue;
            }
        }
        i = 0;
        //電腦
        while (i < 5)
        {
            int n;
            n = Player[1].GetDeck_Fight(Player[1].GetDeck_Draw());
            if (n < 22)
            {
                Player[1].ChangeHand_Status(i, n);
                Player[1].AddDeck_Draw(1);
                i++;
                continue;
            }
            else
            {
                Player[1].AddDeck_Draw(1);
                continue;
            }
        }
        /*
        for (int a = 0; a < 22; a++)
        {
            Debug.Log(Player[1].GetDeck_Fight(a));
        }
        for (int a = 0; a < 5; a++)
        {
            Debug.Log(Player[1].GetHand_Status(a));
        }*/
    }
    public static void Draw(int s,int n) //s=要更新的對象 0:玩家 1:敵人 n=摸牌的數量
    {
        int ii = 0;
        for (int i = 0; i < 5; i++)
        {
            if (Player[s].GetHand_Status(i) == 22)
            {
 
                while (ii < n)
                {
                    int nn;
                    nn = Player[s].GetDeck_Fight(Player[s].GetDeck_Draw());
                    if (nn < 22)
                    {
                        Player[s].ChangeHand_Status(i, nn);
                        Player[s].AddDeck_Draw(1);
                        ii++;
                        Player[s].DecDeck_Num(1);
                        continue;
                    }
                    else
                    {
                        Player[s].AddDeck_Draw(1);
                        continue;
                    }
                }
                break;
            }
        }
    }
    public static void ShowHand(int s) //要更新的對象 0:玩家 1:敵人 顯示手牌
    {
        for(int i = 0; i < 5; i++)
        {
            int n = 0; 
            n=Player[s].GetHand_Status(i);
            UpdateHand(s,i, n);
        }
    }
    public static void UpdateHand(int s,int i, int n) //s=對象 i=第i張手牌 n=卡牌 顯示手牌圖片
    {
        Image i_temp;
            if (s == 0)
            {
                i_temp = GameObject.Find("Image_Hand_A_" + (i + 1).ToString()).GetComponent<Image>();
                if (n == 22) //22 = 沒牌
                    i_temp.sprite = Resources.Load("Image/Battle/Hand", typeof(Sprite)) as Sprite;
                else
                    i_temp.sprite = Resources.Load("Image/Card/" + card_temp[n].GetPicture(), typeof(Sprite)) as Sprite;
                i_temp.color = new Color32(255, 255, 255, 255);
            }
            else
            {
                i_temp = GameObject.Find("Image_Hand_B_" + (i + 1).ToString()).GetComponent<Image>();
                if (n == 22) //22 = 沒牌
                {
                    i_temp.sprite = Resources.Load("Image/Battle/Hand", typeof(Sprite)) as Sprite;
                }
                else
                    //i_temp.sprite = Resources.Load("Image/Card/" + card_temp[n].GetPicture(), typeof(Sprite)) as Sprite;
                    i_temp.sprite = Resources.Load("Image/Card/CardBack", typeof(Sprite)) as Sprite;
        }
    }
    public static void Shuffle(int n) //要更新的對象 0:玩家 1:敵人 遊戲開始亂數牌組
    {
        int r;
        for (int i = 0; i < 22; i++)
        {
            r = Random.Range(0, 22);
            string temp;
            temp = Player[n].GetDeck_Fight(i).ToString();
            Player[n].ChangeDeck_Fight(i, Player[n].GetDeck_Fight(r));
            Player[n].ChangeDeck_Fight(r, int.Parse(temp));
        }
    }

}
