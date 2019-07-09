using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static class Player_Data{

    private static Player_Class[] Player = new Player_Class[2];  // 0:自己 1:敵人

    public static void Player_Init()
    {
        //Debug.Log(Learner_Data.Learner_GetData("Cards_Num").ToString());
        Player[0] = new Player_Class(20, Learner_Data.Learner_GetData("Cards_Num"), 5, 0); //Card_Num = 10
        Player[1] = new Player_Class(20,22,5,0);

        for(int i = 0; i < 22; i++)
        {

        }

        for(int i = 0; i < 22; i++)
        {
            Player[1].ChangeDeck_Status(i,i+1);
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
