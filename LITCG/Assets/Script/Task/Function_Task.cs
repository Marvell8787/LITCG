using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
static class Check
{
    public static string s = "";
    public static int Choose = 0;
}

public class Function_Task : MonoBehaviour {
    void Start()
    {
        ClearAllText();
        
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
                case 0: //未接 未達門檻
                    t_temp.color = Color.black;
                    break;
                case 1: //未接 已達門檻
                    t_temp.color = Color.black;
                    break;
                case 2: //接下
                    t_temp.color = Color.blue;
                    break;
                case 3: //失敗
                    t_temp.color = Color.red;
                    break;
                case 4: //成功
                    t_temp.color = Color.green;
                    break;
                case 5: //完成
                    t_temp.color = Color.gray;
                    t_temp.fontStyle = FontStyle.Italic;
                    break;
            }
        }
        b_temp = GameObject.Find("Button_Learn").GetComponent<Button>();
        b_temp.interactable = false;
        b_temp = GameObject.Find("Button_Battle").GetComponent<Button>();
        b_temp.interactable = true;
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
                case 0: //未接 未達門檻
                    t_temp.color = Color.black;
                    break;
                case 1: //未接 已達門檻
                    t_temp.color = Color.black;
                    break;
                case 2: //接下
                    t_temp.color = Color.blue;
                    break;
                case 3: //失敗
                    t_temp.color = Color.red;
                    break;
                case 4: //成功
                    t_temp.color = Color.green;
                    break;
                case 5: //完成
                    t_temp.color = Color.gray;
                    t_temp.fontStyle = FontStyle.Italic;
                    break;
            }
        }
        b_temp = GameObject.Find("Button_Learn").GetComponent<Button>();
        b_temp.interactable = true;
        b_temp = GameObject.Find("Button_Battle").GetComponent<Button>();
        b_temp.interactable = false;
    }

    public void Back() //回首頁
    {
        SceneManager.LoadScene("Home");
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

        switch (n)
        {
            case 0: //未接 但未達門檻
                b_temp = GameObject.Find("Button_Accept").GetComponent<Button>();
                b_temp.interactable = false;
                break;
            case 1: //未接 但已達門檻
                b_temp = GameObject.Find("Button_Accept").GetComponent<Button>();
                b_temp.interactable = true;
                break;
            case 2: //接下
                b_temp = GameObject.Find("Button_Accept").GetComponent<Button>();
                b_temp.interactable = false;
                break;
            case 3: //失敗
            case 4: //成功
                b_temp = GameObject.Find("Button_Accept").GetComponent<Button>();
                b_temp.interactable = false;
                b_temp = GameObject.Find("Button_Finish").GetComponent<Button>();
                b_temp.interactable = true;
                break;
            case 5: //已完成
                b_temp = GameObject.Find("Button_Accept").GetComponent<Button>();
                b_temp.interactable = false;
                b_temp = GameObject.Find("Button_Finish").GetComponent<Button>();
                b_temp.interactable = false;
                break;
            default:
                break;
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

        //改變狀態
        Task_Data.ChangeStatus(Check.s,Check.Choose,2);
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
        Task_Data.ChangeStatus(Check.s, Check.Choose, 5);
        Task_Class task_temp = new Task_Class();
        Task_Class[] task_reg = new Task_Class[7];

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

        for (int i = 0; i < 7; i++)
        {
            task_temp = Task_Data.Learn_Get(i);
        }
        if(task_reg[0].GetStatus()==5 && task_reg[1].GetStatus() == 5 && task_reg[2].GetStatus() == 0)
        {
            Task_Data.ChangeStatus("learn", 2, 1);
        }
        else if (task_reg[3].GetStatus() == 5 && task_reg[4].GetStatus() == 5 && task_reg[5].GetStatus() == 0)
        {
            Task_Data.ChangeStatus("learn", 5, 1);
        }
    }
}
