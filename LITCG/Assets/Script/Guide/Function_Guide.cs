using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

static class Guide_Check
{
    public static int Code = 0; // 1:任務 2:學習 3:對戰 4:持有物 
    public static int PageUP = 0;
    public static int PageDown = 0;
}

public class Function_Guide : MonoBehaviour {

	public void Task () {
        Text t_temp;
        t_temp = GameObject.Find("Text_Content").GetComponent<Text>();
        Guide_Check.Code = 1;
        Guide_Check.PageUP = 1;
        Guide_Check.PageDown = 1;
        PageChage();
        switch (System_Data.language)
        {
            case 0:
                t_temp.text = Guide_Bank.C_Task_Content;
                break;
            case 1:
                t_temp.text = Guide_Bank.E_Task_Content;
                break;
            default:
                t_temp.text = Guide_Bank.C_Task_Content;
                break;
        }

    }
    public void Learn(){
        Text t_temp;
        t_temp = GameObject.Find("Text_Content").GetComponent<Text>();
        Guide_Check.Code = 2;
        Guide_Check.PageUP = 1;
        Guide_Check.PageDown = 1;
        PageChage();
        switch (System_Data.language)
        {
            case 0:
                t_temp.text = Guide_Bank.C_Learn_Content;
                break;
            case 1:
                t_temp.text = Guide_Bank.E_Learn_Content;
                break;
            default:
                t_temp.text = Guide_Bank.C_Learn_Content;
                break;
        }
    }
    public void Battle()
    {
        Text t_temp;
        t_temp = GameObject.Find("Text_Content").GetComponent<Text>();
        Guide_Check.Code = 3;
        Guide_Check.PageUP = 1;
        Guide_Check.PageDown = 2;
        PageChage();
        switch (System_Data.language)
        {
            case 0:
                t_temp.text = Guide_Bank.C_Battle_Content[Guide_Check.PageUP-1];
                break;
            case 1:
                t_temp.text = Guide_Bank.E_Learn_Content;
                break;
            default:
                t_temp.text = Guide_Bank.C_Battle_Content[Guide_Check.PageUP - 1];
                break;
        }
    }
    public void Item()
    {
        Text T_Temp;
        T_Temp = GameObject.Find("Text_Content").GetComponent<Text>();
        T_Temp.text = "●分數:根據對戰狀況變動\n";
        T_Temp.text += "●金幣:商店購買商品\n";
        T_Temp.text += "●水晶:任務指標\n";
        T_Temp.text += "●獎章:成就達成時給予的獎勵 \n";
        T_Temp.text += "●卡片:對戰用\n";
        T_Temp.text += "●點數:無法針對項目懲罰時的懲罰項目\n";
        T_Temp.text += "●失誤:失敗次數的指標\n";
    }
    public void Previous()
    {

    }
    public void Next()
    {

    }
    public void PageChage()
    {
        Text t_temp;
        t_temp = GameObject.Find("Text_PageUP").GetComponent<Text>();
        t_temp.text = Guide_Check.PageUP.ToString();
        t_temp = GameObject.Find("Text_PageDown").GetComponent<Text>();
        t_temp.text = Guide_Check.PageDown.ToString();
    }
}
