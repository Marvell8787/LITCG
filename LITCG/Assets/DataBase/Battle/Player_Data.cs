using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static class Player_Data{

    private static Player_Class Player ;  // 0:自己 1:敵人

    public static void Player_Init()
    {
        //Debug.Log(Learner_Data.Learner_GetData("Cards_Num").ToString());
        Player = new Player_Class(20, Learner_Data.Learner_GetData("Cards_Num"), 5, 0); //Card_Num = 10
    }

    public static Player_Class Player_Get(int n)
    {
        return Player;
    }
    public static void Update_Deck()
    {

    }
    public static void Update_Hand()
    {

    }
}
