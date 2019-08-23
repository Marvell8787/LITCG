using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Text_Count_RoomFight : MonoBehaviour {
    int time_int = 6;
    //public Text t_temp; //可從外部放
    Text t_temp;
    private Player_Class Player = new Player_Class();
    private Player_Class Enemy = new Player_Class();
    void Start () {
        t_temp = GameObject.Find("Text_Count").GetComponent<Text>();
        InvokeRepeating("timer", 1, 1);
    }

    void timer()
    {

        time_int -= 1;

        t_temp.text = (time_int-1) + "";

        if(time_int == 1)
            t_temp.text = "Play!";

        if (time_int == 0)
        {
            CancelInvoke("timer");

            Image i_temp;

            //Destroy(t_temp,1);
            t_temp.text = "";
            t_temp.rectTransform.localPosition = new Vector3(-50f, 350f, 0f);

            

            i_temp = GameObject.Find("Image_Test").GetComponent<Image>();
            i_temp.color = Color.white;

            Text temp;
            switch (System_Data.language)
            {
                case 0:
                    temp = GameObject.Find("Text_Status").GetComponent<Text>();
                    temp.text = "請答題!";
                    break;
                case 1:
                    temp = GameObject.Find("Text_Status").GetComponent<Text>();
                    temp.text = "Question !";
                    break;
                default:
                    break;
            }


            BQuestion_Class question_temp = new BQuestion_Class();
            BQuestion_Data.BQuestion_Init();
            BQuestion_Check.Question_Num = 0; //init

            question_temp = BQuestion_Data.BQuestion_Get(0);
            temp = GameObject.Find("Text_Q_Num").GetComponent<Text>();
            temp.text = (BQuestion_Check.Question_Num + 1).ToString() + ".";
            temp = GameObject.Find("Text_Q").GetComponent<Text>();
            temp.text = question_temp.GetQuestion();
            BQuestion_Data.Button_Ans_Set();

            Button b_temp;

            b_temp = GameObject.Find("Button_Ans_1").GetComponent<Button>();
            b_temp.interactable = true;
            b_temp = GameObject.Find("Button_Ans_2").GetComponent<Button>();
            b_temp.interactable = true;
            b_temp = GameObject.Find("Button_Ans_3").GetComponent<Button>();
            b_temp.interactable = true;
        }

    }
}
