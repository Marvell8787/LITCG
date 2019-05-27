using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
static class Check
{
    public static string s = "";
    public static int Choose = 0;
}

public class Function_Task : MonoBehaviour {
    void Start()
    {
        ClearAllText();

        Task_Data.Learn_Init();
        Task_Data.Battle_Init();

        Button b_temp;
        b_temp = GameObject.Find("Button_Accept").GetComponent<Button>();
        b_temp.interactable = false;
        b_temp = GameObject.Find("Button_Finish").GetComponent<Button>();
        b_temp.interactable = false;
    }
    public void GetLearnData() //獲取 LearnData
    {
        Button b_temp;
        b_temp = GameObject.Find("Button_Accept").GetComponent<Button>();
        b_temp.interactable = false;

        Check.s = "learn";
        ClearAllText();
        Task_Class[] learn_temp = new Task_Class[7];
        for (int i =0; i < 7; i++){
            learn_temp[i] = Task_Data.Learn_Get(i);
        }

        Text t_temp;
        for (int i = 0; i < 7; i++)
        {
            t_temp = GameObject.Find("Text_Task_" + (i + 1).ToString()).GetComponent<Text>();
            t_temp.text = learn_temp[i].GetTitle();
            switch (learn_temp[i].GetStatus())
            {
                case 0: //未接
                    t_temp.color = Color.black;
                    break;
                case 1: //接下
                    t_temp.color = Color.blue;
                    break;
                case 2: //失敗
                    t_temp.color = Color.red;
                    break;
                case 3: //成功
                    t_temp.color = Color.green;
                    break;
                case 4: //完成
                    t_temp.color = Color.gray;
                    t_temp.fontStyle = FontStyle.Italic;
                    break;
            }
        }
    }

    public void GetBattleData() //獲取 BattleData
    {
        Button b_temp;
        b_temp = GameObject.Find("Button_Accept").GetComponent<Button>();
        b_temp.interactable = false;

        Check.s = "battle";
        ClearAllText();
        Task_Class[] battle_temp = new Task_Class[3];
        for (int i = 0; i <3 ; i++)
        {
            battle_temp[i] = Task_Data.Battle_Get(i);
        }

        Text t_temp;
        for (int i = 0; i < 3; i++)
        {
            t_temp = GameObject.Find("Text_Task_" + (i+1).ToString()).GetComponent<Text>();
            t_temp.text = battle_temp[i].GetTitle();
            switch(battle_temp[i].GetStatus())
            {
                case 0: //未接
                    t_temp.color = Color.black;
                    break;
                case 1: //接下
                    t_temp.color = Color.blue;
                    break;
                case 2: //失敗
                    t_temp.color = Color.red;
                    break;
                case 3: //成功
                    t_temp.color = Color.green;
                    break;
                case 4: //完成
                    t_temp.color = Color.gray;
                    t_temp.fontStyle = FontStyle.Italic;
                    break;
            }
        }
    }

    public void BackHome() //回首頁
    {
        Debug.Log("BackHome");
    }
    public void ClearAllText() //清除所有Text
    {
        Text t_temp;
        for(int i = 0; i < 7; i++)
        {
            t_temp = GameObject.Find("Text_Task_" + (i+1).ToString() ).GetComponent<Text>();
            t_temp.text = "";
        }
        t_temp = GameObject.Find("Text_ThresholdContent").GetComponent<Text>();
        t_temp.text = "";
        t_temp = GameObject.Find("Text_RequestContent").GetComponent<Text>();
        t_temp.text = "";
        t_temp = GameObject.Find("Text_RewardContent").GetComponent<Text>();
        t_temp.text = "";
        t_temp = GameObject.Find("Text_PunishmentContent").GetComponent<Text>();
        t_temp.text = "";
    }
    //任務內容接下
    public void PressContent_1()
    {
        if (Check.s != "")
        {
            Check.Choose = 0;
            Button_Change();
            ShowContent(Check.s, 0);
        }
    }
    public void PressContent_2()
    {
        if (Check.s != "")
        {
            Check.Choose = 1;
            Button_Change();
            ShowContent(Check.s, 1);
        }
    }
    public void PressContent_3()
    {
        if (Check.s != "")
        {
            Check.Choose = 2;
            Button_Change();
            ShowContent(Check.s, 2);
        }
    }
    public void PressContent_4()
    {
        if (Check.s != "")
        {
            Check.Choose = 3;
            Button_Change();
            ShowContent(Check.s, 3);
        }
    }
    public void PressContent_5()
    {
        if (Check.s != "")
        {
            Check.Choose = 4;
            Button_Change();
            ShowContent(Check.s, 4);
        }
    }
    public void PressContent_6()
    {
        if (Check.s != "")
        {
            Check.Choose = 5;
            Button_Change();
            ShowContent(Check.s, 5);
        }
    }
    public void PressContent_7()
    {
        if (Check.s != "")
        {
            Check.Choose = 6;
            Button_Change();
            ShowContent(Check.s, 6);
        }
    }

    public void Button_Change()
    {
        int n;
        Task_Class task_temp = new Task_Class();
        if (Check.s == "learn")
            task_temp = Task_Data.Learn_Get(Check.Choose);
        else if (Check.s == "battle")
            task_temp = Task_Data.Battle_Get(Check.Choose);

        Button b_temp;
        n = task_temp.GetStatus();

        if (n > 1 && n < 4)
        {
            b_temp = GameObject.Find("Button_Accept").GetComponent<Button>();
            b_temp.interactable = false;

            b_temp = GameObject.Find("Button_Finish").GetComponent<Button>();
            b_temp.interactable = true;
        }
        else if (n == 0)
        {
            b_temp = GameObject.Find("Button_Accept").GetComponent<Button>();
            b_temp.interactable = true;
        }
        else if (n == 1)
        {
            b_temp = GameObject.Find("Button_Accept").GetComponent<Button>();
            b_temp.interactable = false;
        }
    }

    public void ShowContent(string s,int n)
    {
        Text t_temp;
        Task_Class task_temp = new Task_Class();
        if (s == "learn")
            task_temp = Task_Data.Learn_Get(n);
        else if (s == "battle")
            task_temp = Task_Data.Battle_Get(n);

        t_temp = GameObject.Find("Text_ThresholdContent").GetComponent<Text>();
        t_temp.text = task_temp.GetThreshold();
        t_temp = GameObject.Find("Text_RequestContent").GetComponent<Text>();
        t_temp.text = task_temp.GetRequest();
        t_temp = GameObject.Find("Text_RewardContent").GetComponent<Text>();
        t_temp.text = task_temp.GetReward();
        t_temp = GameObject.Find("Text_PunishmentContent").GetComponent<Text>();
        t_temp.text = task_temp.GetPunishment();
    }
    public void Accept()
    {
        Button b_temp;
        Text t_temp;
        Task_Data.ChangeStatus(Check.s,Check.Choose,1);
        Task_Class task_temp = new Task_Class();

        if (Check.s == "learn")
            task_temp = Task_Data.Learn_Get(Check.Choose);
        else if (Check.s == "battle")
            task_temp = Task_Data.Battle_Get(Check.Choose);

        b_temp = GameObject.Find("Button_Accept").GetComponent<Button>();
        b_temp.interactable = false;

        t_temp = GameObject.Find("Text_Task_" + (Check.Choose + 1).ToString()).GetComponent<Text>();
        t_temp.text = task_temp.GetTitle();
        t_temp.color = Color.blue;

    }
    public void Finish()
    {
        Button b_temp;
        Text t_temp;
        Task_Data.ChangeStatus(Check.s, Check.Choose, 4);
        Task_Class task_temp = new Task_Class();

        if (Check.s == "learn")
            task_temp = Task_Data.Learn_Get(Check.Choose);
        else if (Check.s == "battle")
            task_temp = Task_Data.Battle_Get(Check.Choose);

        b_temp = GameObject.Find("Button_Finish").GetComponent<Button>();
        b_temp.interactable = false;

        t_temp = GameObject.Find("Text_Task_" + (Check.Choose + 1).ToString()).GetComponent<Text>();
        t_temp.text = task_temp.GetTitle();
        t_temp.color = Color.gray;
        t_temp.fontStyle = FontStyle.Italic;
    }
}
