using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QP_RoomFight : MonoBehaviour {

    private  Player_Class Player;  // 0:自己 1:敵人

    public void Choose_A()
    {
        BQuestion_Check.Choose_Ans = "A";
        BQuestion_Check.Choose_Ans_n = 0;
        BQuestion_Check.Choose_Ans_Content = Question_Data.GetButton_Ans(0);
        //Debug.Log(Question_Check.Choose_Ans_Content);

        CheckAns();
    }
    public void Choose_B()
    {
        BQuestion_Check.Choose_Ans = "B";
        BQuestion_Check.Choose_Ans_n = 1;
        BQuestion_Check.Choose_Ans_Content = Question_Data.GetButton_Ans(1);
        //Debug.Log(Question_Check.Choose_Ans_Content);

        CheckAns();
    }
    public void Choose_C()
    {
        BQuestion_Check.Choose_Ans = "C";
        BQuestion_Check.Choose_Ans_n = 2;
        BQuestion_Check.Choose_Ans_Content = Question_Data.GetButton_Ans(2);
        //Debug.Log(Question_Check.Choose_Ans_Content);

        CheckAns();
    }

    public void CheckAns()
    {
        Text t_temp;
        Button b_temp;
        BQuestion_Class question_temp = new BQuestion_Class();

        BQuestion_Data.ChangeAnswer_c(BQuestion_Check.Choose_Ans, BQuestion_Check.Question_Num);
        BQuestion_Data.ChangeAnswer_c_Content(BQuestion_Check.Choose_Ans_Content, BQuestion_Check.Question_Num);

        question_temp = BQuestion_Data.BQuestion_Get(BQuestion_Check.Question_Num); ;
        Player = Player_Data.Player_Get(0);

        if (question_temp.GetAnswer_r() == question_temp.GetAnswer_c())
        {
            BQuestion_Data.ChangeFeedBack("O", BQuestion_Check.Question_Num);
            t_temp = GameObject.Find("Text_Answer").GetComponent<Text>();
            t_temp.text = "Ans:" + question_temp.GetAnswer_r_Content();
            t_temp = GameObject.Find("Text_Status").GetComponent<Text>();
            t_temp.text = "答對了!";
        }
        else
        {
            BQuestion_Data.ChangeFeedBack("X", Question_Check.Question_Num);
            t_temp = GameObject.Find("Text_Answer").GetComponent<Text>();
            t_temp.text = "Ans:" + question_temp.GetAnswer_r_Content();
            t_temp = GameObject.Find("Text_Status").GetComponent<Text>();
            t_temp.text = "答錯了!";

            Player.ChangeLP(Player.GetLP() - 5);

            t_temp = GameObject.Find("Text_LP_A_num").GetComponent<Text>();
            t_temp.text = Player.GetLP().ToString();

        }


        b_temp = GameObject.Find("Button_Ans_1").GetComponent<Button>();
        b_temp.interactable = false;
        b_temp = GameObject.Find("Button_Ans_2").GetComponent<Button>();
        b_temp.interactable = false;
        b_temp = GameObject.Find("Button_Ans_3").GetComponent<Button>();
        b_temp.interactable = false;


        if (BQuestion_Check.Question_Num == 9)
        {
            t_temp = GameObject.Find("Text_Count").GetComponent<Text>();
            t_temp.text = "最後一個回合!";
            t_temp.color = new Color32(255, 0, 0, 255);
            t_temp.rectTransform.localPosition = new Vector3(-50f, 0f, 0f);
        }
        else if (Player.GetLP()<=0)
        {
            t_temp = GameObject.Find("Text_Status").GetComponent<Text>();
            t_temp.text = "遊戲結束!";
            b_temp = GameObject.Find("Button_NEXT").GetComponent<Button>();
            b_temp.GetComponentInChildren<Text>().text = "END";
            b_temp.interactable = true;
        }
        else
        {
            b_temp = GameObject.Find("Button_START").GetComponent<Button>();
            b_temp.interactable = true;
            BQuestion_Check.Question_Num++;
        }
    }
}
