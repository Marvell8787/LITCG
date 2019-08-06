using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BP_RoomFight : MonoBehaviour {

    private Player_Class Player = new Player_Class();
    private Player_Class Enemy = new Player_Class();

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
        b_temp = GameObject.Find("Button_USE").GetComponent<Button>();
        b_temp.interactable = false;
    }
    public void BACK()
    {

    }
}
