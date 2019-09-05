using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
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
                t_temp.text = Guide_Bank.E_Battle_Content[Guide_Check.PageUP - 1];
                break;
            default:
                t_temp.text = Guide_Bank.C_Battle_Content[Guide_Check.PageUP - 1];
                break;
        }
    }
    public void Item()
    {
        Text t_temp;
        t_temp = GameObject.Find("Text_Content").GetComponent<Text>();
        Guide_Check.Code = 4;
        Guide_Check.PageUP = 1;
        Guide_Check.PageDown = 1;
        PageChage();
        switch (System_Data.language)
        {
            case 0:
                t_temp.text = Guide_Bank.C_Item_Content;
                break;
            case 1:
                t_temp.text = Guide_Bank.E_Item_Content;
                break;
            default:
                t_temp.text = Guide_Bank.C_Item_Content;
                break;
        }
    }
    public void Previous()
    {
        Text t_temp;
        if (Guide_Check.PageUP > 1)
        {
            Guide_Check.PageUP--;
            PageChage();
        }

        switch (Guide_Check.Code)
        {
            case 3://對戰
                t_temp = GameObject.Find("Text_Content").GetComponent<Text>();
                switch (System_Data.language)
                {
                    case 0:
                        t_temp.text = Guide_Bank.C_Battle_Content[Guide_Check.PageUP - 1];
                        break;
                    case 1:
                        t_temp.text = Guide_Bank.E_Learn_Content;
                        break;
                    default:
                        t_temp.text = Guide_Bank.C_Battle_Content[Guide_Check.PageUP - 1];
                        break;
                }
                break;
            case 4:
                break;
            default:
                break;
        }
    }
    public void Next()
    {
        Text t_temp;
        if (Guide_Check.PageUP < Guide_Check.PageDown)
        {
            Guide_Check.PageUP++;
            PageChage();
        }
        switch (Guide_Check.Code)
        {
            case 3://對戰
                t_temp = GameObject.Find("Text_Content").GetComponent<Text>();
                switch (System_Data.language)
                {
                    case 0:
                        t_temp.text = Guide_Bank.C_Battle_Content[Guide_Check.PageUP - 1];
                        break;
                    case 1:
                        t_temp.text = Guide_Bank.E_Learn_Content;
                        break;
                    default:
                        t_temp.text = Guide_Bank.C_Battle_Content[Guide_Check.PageUP - 1];
                        break;
                }
                break;
            case 4:
                break;
            default:
                break;
        }

    }
    public void PageChage()
    {
        Text t_temp;
        t_temp = GameObject.Find("Text_PageUP").GetComponent<Text>();
        t_temp.text = Guide_Check.PageUP.ToString();
        t_temp = GameObject.Find("Text_PageDown").GetComponent<Text>();
        t_temp.text = Guide_Check.PageDown.ToString();
    }
    public void Back()
    {
        SceneManager.LoadScene("Home");
    }

}
