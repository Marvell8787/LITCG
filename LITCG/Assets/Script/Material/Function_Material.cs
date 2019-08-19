using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
static class Material_Check
{
    public static string s = ""; //vocabulary
    public static int Choose = 0;
    public static int ten = 0;

}

public class Function_Material : MonoBehaviour {

    // Use this for initialization
    public void Back()
    {
        Application.LoadLevel("Learn");
    }
    public void Right()
    {
        if (Material_Check.Choose > 8 && Material_Check.ten == 10)
        {
            Material_Check.Choose = 0;
            Material_Check.ten = 0;
            ChangeButtonText();
        }
        else
        {
            Material_Check.Choose++ ;
            if(Material_Check.Choose == 10)
            {
                Material_Check.ten = 10;
                Material_Check.Choose = 0;
                ChangeButtonText();
            }

        }
        ShowContent(Material_Check.Choose + Material_Check.ten );
    }
    public void Left()
    {
        if (Material_Check.Choose < 1 && Material_Check.ten == 0)
        {
            Material_Check.Choose = 9;
            Material_Check.ten = 10;
            ChangeButtonText();
        }
        else
        {
            Material_Check.Choose--;
            if (Material_Check.Choose == -1)
            {
                Material_Check.ten = 0;
                Material_Check.Choose = 9;
                ChangeButtonText();
            }

        }
        ShowContent(Material_Check.Choose + Material_Check.ten );
    }
    public void Up()
    {
        if (Material_Check.ten == 0)
        {
            Material_Check.ten = 10;
        }
        else
        {
            Material_Check.ten = 0;

        }
        ShowContent(Material_Check.Choose + Material_Check.ten);
        ChangeButtonText();
    }
    public void Down()
    {
        if (Material_Check.ten == 10)
        {
            Material_Check.ten = 0;
        }
        else
        {
            Material_Check.ten = 10;

        }
        ShowContent(Material_Check.Choose + Material_Check.ten);
        ChangeButtonText();
    }
    // Button Choose Start 以後要優化
    public void Button_1()
    {
        Material_Check.Choose = 0;
        ShowContent(Material_Check.Choose + Material_Check.ten );
    }
    public void Button_2()
    {
        Material_Check.Choose = 1;
        ShowContent(Material_Check.Choose + Material_Check.ten );
    }
    public void Button_3()
    {
        Material_Check.Choose = 2;
        ShowContent(Material_Check.Choose + Material_Check.ten );
    }
    public void Button_4()
    {
        Material_Check.Choose = 3;
        ShowContent(Material_Check.Choose + Material_Check.ten );
    }
    public void Button_5()
    {
        Material_Check.Choose = 4;
        ShowContent(Material_Check.Choose + Material_Check.ten );
    }
    public void Button_6()
    {
        Material_Check.Choose = 5;
        ShowContent(Material_Check.Choose + Material_Check.ten );
    }
    public void Button_7()
    {
        Material_Check.Choose = 6;
        ShowContent(Material_Check.Choose + Material_Check.ten );
    }
    public void Button_8()
    {
        Material_Check.Choose = 7;
        ShowContent(Material_Check.Choose + Material_Check.ten );
    }
    public void Button_9()
    {
        Material_Check.Choose = 8;
        ShowContent(Material_Check.Choose + Material_Check.ten );
    }
    public void Button_10()
    {
        Material_Check.Choose = 9;
        ShowContent(Material_Check.Choose + Material_Check.ten );
    }
    // Button Choose End
    public void ShowContent(int n)
    {
        Text t_temp;
        Vocabulary_Class vocabulary_temp = new Vocabulary_Class();
        vocabulary_temp = Vocabulary_Data.Vocabulary_Get(n);

        t_temp = GameObject.Find("Text_Num").GetComponent<Text>();
        t_temp.text = (n+1).ToString() + "." ;

        t_temp = GameObject.Find("Text_E_Name").GetComponent<Text>();
        t_temp.text = vocabulary_temp.GetE_Name();
        t_temp = GameObject.Find("Text_C_Name").GetComponent<Text>();
        t_temp.text = vocabulary_temp.GetC_Name();

        t_temp = GameObject.Find("Text_PartOfSpeech").GetComponent<Text>();
        t_temp.text = vocabulary_temp.GetPartOfSpeech();

        t_temp = GameObject.Find("Text_Sentence").GetComponent<Text>();
        t_temp.text = vocabulary_temp.GetSentence();
    }
    public void ChangeButtonText()
    {
        Button b_temp;
        Vocabulary_Class vocabulary_temp = new Vocabulary_Class();
        for (int i = 1; i <= 10; i++)
        {
            b_temp = GameObject.Find("Button_" + i.ToString()).GetComponent<Button>();
            vocabulary_temp = Vocabulary_Data.Vocabulary_Get(Material_Check.ten + (i - 1));
            b_temp.GetComponentInChildren<Text>().text = vocabulary_temp.GetE_Name();
        }
    }



}
