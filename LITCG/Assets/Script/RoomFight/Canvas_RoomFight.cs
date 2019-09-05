using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class Canvas_RoomFight : MonoBehaviour {

    private Player_Class Player = new Player_Class();
    private Player_Class Enemy = new Player_Class();

    // Use this for initialization
    void Start () {
        Button b_temp;

        Player = Player_Data.Player_Get(0);
        Enemy = Player_Data.Player_Get(1);

        Text t_temp;
        t_temp = GameObject.Find("Text_LP_A_num").GetComponent<Text>();
        t_temp.text = Player.GetLP().ToString();
        t_temp = GameObject.Find("Text_Deck_A_num").GetComponent<Text>();
        t_temp.text = (Player.GetDeck_Num()-5).ToString();
        Player.DecDeck_Num(5);

        t_temp = GameObject.Find("Text_LP_B_num").GetComponent<Text>();
        t_temp.text = Enemy.GetLP().ToString();
        t_temp = GameObject.Find("Text_Deck_B_num").GetComponent<Text>();
        t_temp.text = (Enemy.GetDeck_Num() - 5).ToString();
        Enemy.DecDeck_Num(5);

        BattleCheck.A_ATK = 0;
        BattleCheck.B_ATK = 0;
        t_temp = GameObject.Find("Text_ATK_A_num").GetComponent<Text>();
        t_temp.text = (BattleCheck.A_ATK).ToString();
        t_temp = GameObject.Find("Text_ATK_B_num").GetComponent<Text>();
        t_temp.text = (BattleCheck.B_ATK).ToString();

        switch (System_Data.language)
        {
            case 0:    
                t_temp = GameObject.Find("Text_Deck_A").GetComponent<Text>();
                t_temp.text = "牌組：";
                t_temp = GameObject.Find("Text_Deck_B").GetComponent<Text>();
                t_temp.text = "牌組：";
                b_temp = GameObject.Find("Button_Surrender").GetComponent<Button>();
                b_temp.GetComponentInChildren<Text>().text = "投降";
                b_temp = GameObject.Find("Button_START").GetComponent<Button>();
                b_temp.GetComponentInChildren<Text>().text = "開始";
                b_temp = GameObject.Find("Button_FIGHT").GetComponent<Button>();
                b_temp.GetComponentInChildren<Text>().text = "戰鬥";
                b_temp = GameObject.Find("Button_NEXT").GetComponent<Button>();
                b_temp.GetComponentInChildren<Text>().text = "下一步";
                b_temp = GameObject.Find("Button_USE").GetComponent<Button>();
                b_temp.GetComponentInChildren<Text>().text = "出牌";
                break;
            default:
                break;
        }
    }


}
