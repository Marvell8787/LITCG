using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class Canvas_RoomFight : MonoBehaviour {

    private Player_Class[] Player = new Player_Class[2];  // 0:自己 1:敵人
    private bool f = false;
    // Use this for initialization
    void Start () {

        Player[0] = Player_Data.Player_Get(0);
        Player[1] = Player_Data.Player_Get(1);

        Text t_temp;
        t_temp = GameObject.Find("Text_LP_A_num").GetComponent<Text>();
        t_temp.text = Player[0].GetLP().ToString();
        t_temp = GameObject.Find("Text_LP_B_num").GetComponent<Text>();
        t_temp.text = Player[1].GetLP().ToString();
        t_temp = GameObject.Find("Text_Deck_A_num").GetComponent<Text>();
        t_temp.text = (Player[0].GetDeck_Num()-5).ToString();
        t_temp = GameObject.Find("Text_Deck_B_num").GetComponent<Text>();
        t_temp.text = (Player[1].GetDeck_Num()-5).ToString();


    }


}
