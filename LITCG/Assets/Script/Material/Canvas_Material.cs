using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Canvas_Material : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Vocabulary_Data.Vocabulary_Init();
        Button b_temp;
        Text t_temp;
        switch (System_Data.language)
        {
            case 0:
                b_temp = GameObject.Find("Button_Up").GetComponent<Button>();
                b_temp.GetComponentInChildren<Text>().text = "上一頁";
                b_temp = GameObject.Find("Button_Down").GetComponent<Button>();
                b_temp.GetComponentInChildren<Text>().text = "下一頁";
                b_temp = GameObject.Find("Button_Left").GetComponent<Button>();
                b_temp.GetComponentInChildren<Text>().text = "上一個";
                b_temp = GameObject.Find("Button_Right").GetComponent<Button>();
                b_temp.GetComponentInChildren<Text>().text = "下一個";
                b_temp = GameObject.Find("Button_Back").GetComponent<Button>();
                b_temp.GetComponentInChildren<Text>().text = "返回";
                break;
            default:
                break;
        }

        ShowContent(Material_Check.Choose);
        ChangeButtonText();
    }
    public void ShowContent(int n)
    {
        Text t_temp;
        Vocabulary_Class vocabulary_temp = new Vocabulary_Class();
        vocabulary_temp = Vocabulary_Data.Vocabulary_Get(n);

        t_temp = GameObject.Find("Text_Num").GetComponent<Text>();
        t_temp.text = (n + 1).ToString() + ".";

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
            vocabulary_temp = Vocabulary_Data.Vocabulary_Get(Material_Check.ten + (i-1));
            b_temp.GetComponentInChildren<Text>().text = vocabulary_temp.GetE_Name();
        }
    }
}
