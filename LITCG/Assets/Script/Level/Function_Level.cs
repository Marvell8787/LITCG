using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Function_Level : MonoBehaviour {
    //Button
    public void Back()
    {
        Application.LoadLevel("Learn");
    }
    public void Level_1()
    {
        Level_Check.choose = 0;
        ShowContent(Level_Check.choose);
    }
    public void Level_2()
    {
        Level_Check.choose = 1;
        ShowContent(Level_Check.choose);
    }
    public void Level_3()
    {
        Level_Check.choose = 2;
        ShowContent(Level_Check.choose);
    }
    public void Level_4()
    {
        Level_Check.choose = 3;
        ShowContent(Level_Check.choose);
    }
    public void Level_5()
    {
        Level_Check.choose = 4;
        ShowContent(Level_Check.choose);
    }
    public void Level_6()
    {
        Level_Check.choose = 5;
        ShowContent(Level_Check.choose);
    }
    public void Overall()
    {
        Level_Check.choose = 6;
        ShowContent(Level_Check.choose);
    }
    public void Challenge()
    {
        if (Level_Check.choose < 6)
            Application.LoadLevel("Level_Learn");
        else
            Application.LoadLevel("Overall");
    }
    public void ShowContent(int n)
    {
        Text t_temp;
        Button b_temp;
        Level_Class level_temp = new Level_Class();
        level_temp = Level_Data.Level_Get(n);

        t_temp = GameObject.Find("Text_QuestionTypeContent").GetComponent<Text>();
        t_temp.text = level_temp.GetQuestionType();
        t_temp = GameObject.Find("Text_RangeContent").GetComponent<Text>();
        t_temp.text = level_temp.GetRange();
        t_temp = GameObject.Find("Text_RewardContent").GetComponent<Text>();
        t_temp.text = level_temp.GetReward();
        t_temp = GameObject.Find("Text_PunishmentContent").GetComponent<Text>();
        t_temp.text = level_temp.GetPunishment();
        t_temp = GameObject.Find("Text_HighestScoreContent").GetComponent<Text>();
        t_temp.text = level_temp.GetHighestScore();

        b_temp = GameObject.Find("Button_Challenge").GetComponent<Button>();
        b_temp.interactable = true;
    }
}
