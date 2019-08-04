using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Text_Count_RoomFight : MonoBehaviour {
    int time_int = 5;
    //public Text t_temp; //可從外部放
    Text t_temp;
    // Use this for initialization
    void Start () {
        t_temp = GameObject.Find("Text_Count").GetComponent<Text>();
        InvokeRepeating("timer", 1, 1);
    }

    void timer()
    {

        time_int -= 1;

        t_temp.text = time_int + "";

        if (time_int == 0)
        {
            t_temp.text = "Play!";
            CancelInvoke("timer");

            Image i_temp;

            Destroy(t_temp,1);
            i_temp = GameObject.Find("Image_Test").GetComponent<Image>();
            i_temp.color = Color.white;
            i_temp = GameObject.Find("Button_QP").GetComponent<Image>();
            i_temp.color = Color.red;

            Text t_temp;
            t_temp = GameObject.Find("Text_Status").GetComponent<Text>();
            t_temp.text = "請答題!";

        }

    }
}
