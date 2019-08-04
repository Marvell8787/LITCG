using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static class Player_Data{

    private static Player_Class[] Player = new Player_Class[2];  // 0:自己 1:敵人

    public static void Player_Init()
    {
        //Debug.Log(Learner_Data.Learner_GetData("Cards_Num").ToString());
        Player[0] = new Player_Class(20, Learner_Data.Learner_GetData("Cards_Num"), 5, 0); //Card_Num = 10
        switch (Enemy.No)
        {
            case 1:
                Player[1] = new Player_Class(10,10,5,0);
                break;
            case 2:
                Player[1] = new Player_Class(15, 15, 5, 0);
                break;
            case 3:
                Player[1] = new Player_Class(20, 18, 5, 0);
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
