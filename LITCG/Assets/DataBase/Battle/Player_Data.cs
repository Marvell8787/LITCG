using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static class Player_Data{

    private static Player_Class[] Player = new Player_Class[2];  // 0:自己 1:敵人

    public static void Player_Init()
    {
        //Debug.Log(Learner_Data.Learner_GetData("Cards_Num").ToString());
        Player[0] = new Player_Class(20, Learner_Data.Learner_GetData("Cards_Num")); 

        for(int i = 0; i < 22; i++)
        {
            int n;
            n=Learner_Data.Learner_GetCard_Status(i);
            Player[0].ChangeDeck_Status(i,n);
        }


        switch (Enemy.No)
        {
            case 1:
                Player[1] = new Player_Class(10,14);
                for (int i = 0; i < 22; i++)
                {
                    if (i < 12)
                        Player[1].ChangeDeck_Status(i, 1); //0~11
                    else if(i >14 && i<17)
                        Player[1].ChangeDeck_Status(i, 1); //15 16
                    else
                        Player[1].ChangeDeck_Status(i, 0); //12~14 17~21
                }
                break;
            case 2:
                Player[1] = new Player_Class(15, 17);
                for (int i = 0; i < 22; i++)
                {
                    if (i < 14)
                        Player[1].ChangeDeck_Status(i, 1); //0~13
                    else if (i > 14 && i < 18)
                        Player[1].ChangeDeck_Status(i, 1); //15~17
                    else
                        Player[1].ChangeDeck_Status(i, 0); //14 18~21
                }
                break;
            case 3:
                Player[1] = new Player_Class(20, 20);
                for (int i = 0; i < 22; i++)
                {
                    if (i < 18)
                        Player[1].ChangeDeck_Status(i, 1); //0~17
                    else if(i>18 && i<21)
                        Player[1].ChangeDeck_Status(i, 1); //19~20
                    else
                        Player[1].ChangeDeck_Status(i, 0); //18 21
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
    public static void Update_Deck()
    {

    }
    public static void Update_Hand()
    {

    }
}
