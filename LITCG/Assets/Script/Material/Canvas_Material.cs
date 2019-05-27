using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Canvas_Material : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Vocabulary_Data.Vocabulary_Init();
        ShowContent(Material_Check.Choose);
    }
    public void ShowContent(int n)
    {
        Text t_temp;
        Vocabulary_Class vocabulary_temp = new Vocabulary_Class();
        vocabulary_temp = Vocabulary_Data.Vocabulary_Get(n);

        t_temp = GameObject.Find("Text_QuestionNum").GetComponent<Text>();
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
}
