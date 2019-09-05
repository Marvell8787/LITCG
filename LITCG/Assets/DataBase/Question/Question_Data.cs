using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using System.Threading;
static class Question_Check
{
    public static int Question_Num = 0; //第幾題
    public static string Choose_Ans = ""; //選項 ABC
    public static string Choose_Ans_Content = ""; //答案內容
    public static int Choose_Ans_n = 0; //選擇的選項
    public static int Score = 0; //分數

    public static int Question_total = 0; //共幾題

}

static class Question_Data{
    // Level_Learn
    private static string[] Question = new string[20] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
    private static string[] Answer_r_Content = new string[20] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };

    //Overall
    private static string[] O_Question = new string[20] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
    private static string[] O_Question_E = new string[20] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
    private static string[] O_Answer_r_Content = new string[20] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };


    private static string[] Button_Ans = new string[3] { "", "", ""};

    private static string[] Button_Ans_Check = new string[3] { "A", "B", "C" };

    private static Question_Class[] question_temp = new Question_Class[20];
    private static Question_Class[] question_overall_temp = new Question_Class[20];
    private static Question_Class[] question_overall_temp_E = new Question_Class[20];
    private static Vocabulary_Class[] vocabulary_temp = new Vocabulary_Class[20];



    public static void Question_Init()
    {
        Random.InitState(System.Guid.NewGuid().GetHashCode());
        Vocabulary_Data.Vocabulary_Init();
        for(int i = 0; i < 20; i++)
        {
            vocabulary_temp[i] = Vocabulary_Data.Vocabulary_Get(i);
        }
        switch (Level_Check.choose)
        {
            case 0: //Level-1 Listening
                Question_Check.Question_total = 10;
                Question_Vocabulary_Set(1,10);
                break;
            case 1: //Level-2 Listening
                Question_Check.Question_total = 10;
                Question_Vocabulary_Set(11,20);
                break;
            case 2: //Level-3 Listening
                Question_Check.Question_total = 20;
                Question_Vocabulary_Set(1, 20);
                break;
            case 3: //Level-4 英翻中
                Question_Check.Question_total = 10;
                Question_Vocabulary_Set(1, 10);
                break;
            case 4: //Level-5 英翻中
                Question_Check.Question_total = 10;
                Question_Vocabulary_Set(11, 20);
                break;
            case 5: //Level-6 英翻中
                Question_Check.Question_total = 20;
                Question_Vocabulary_Set(1, 20);
                break;
            case 6: //Overall
                Question_Overall_Set();
                break;
            default:
                break;
        }
    }
    public static void Question_Vocabulary_Set(int n1,int n2) // 第n1~第n2題 共n3題
    {
        if(Question_Check.Question_total == 10)
        {
            for (int i = n1-1; i < n2; i++)
            {
                if (n1 > 10)
                {
                    Question[i - 10] = vocabulary_temp[i].GetE_Name();
                    if (Level_Check.choose <= 2)
                        Answer_r_Content[i - 10] = vocabulary_temp[i].GetE_Name();
                    else
                        Answer_r_Content[i - 10] = vocabulary_temp[i].GetC_Name();
                }
                else
                {
                    Question[i] = vocabulary_temp[i].GetE_Name();
                    if (Level_Check.choose <= 2)
                        Answer_r_Content[i] = vocabulary_temp[i].GetE_Name();
                    else
                        Answer_r_Content[i] = vocabulary_temp[i].GetC_Name();
                }
            }  
        }
        else if (Question_Check.Question_total == 20)
        {
            for (int i = n1; i < n2; i++)
            {
                Question[i] = vocabulary_temp[i].GetE_Name();
                if (Level_Check.choose <= 2)
                    Answer_r_Content[i] = vocabulary_temp[i].GetE_Name();
                else
                    Answer_r_Content[i] = vocabulary_temp[i].GetC_Name();
            }
        }

        QaARandomSequence(Question_Check.Question_total);

        for(int i = 0; i < Question_Check.Question_total; i++)
        {
            question_temp[i] = new Question_Class(i+1, Question[i],"", Answer_r_Content[i],"","","");
        }
    }
    public static void Question_Overall_Set()
    {
        for (int i = 0; i < 20; i++)
        {
            O_Question[i] = vocabulary_temp[i].GetC_Name();
            O_Question_E[i] = vocabulary_temp[i].GetE_Name();
            O_Answer_r_Content[i] = vocabulary_temp[i].GetE_Name();
        }
        O_QaARandomSequence(20);

        for (int i = 0; i < 20; i++)
        {
            question_overall_temp[i] = new Question_Class(i + 1, O_Question[i], "", O_Answer_r_Content[i], "", "", "");
            question_overall_temp_E[i] = new Question_Class(i + 1, O_Question_E[i], "", O_Answer_r_Content[i], "", "", "");

        }
    }
    public static void Button_Ans_Set()
    {
        //選項設定START
        int r = 0;
        r = Random.Range(0, 3);
        //亂數陣列 START
        int[] rand = new int[20];
        int c = 0;
        rand = GetRandomSequence(20);
        //亂數陣列 END
        for (int i = 0; i < 3; i++)
        {
            if (r == i)
            {
                ChangeButton_Ans(question_temp[Question_Check.Question_Num].GetAnswer_r_Content(), i);
                ChangeAnswer_r(Button_Ans_Check[r], Question_Check.Question_Num); //設定正解ABC END
            }
            else
            {
                while (true)
                {
                    if (Level_Check.choose <=2)  //英文
                    {
                        if (Question_Bank.Vocabulary_Ans[rand[c]] == (question_temp[Question_Check.Question_Num].GetAnswer_r_Content()))
                        { c++; continue; }
                        else
                        {
                            ChangeButton_Ans(Question_Bank.Vocabulary_Ans[rand[c]], i);
                            c++;
                            break;
                        }
                    }
                    else //中文
                    {
                        if (Question_Bank.Vocabulary_Ans[rand[c]] == (question_temp[Question_Check.Question_Num].GetQuestion()))
                        { c++; continue; }
                        else
                        {
                            ChangeButton_Ans(Question_Bank.Vocabulary_Ans_C_Name[rand[c]], i);
                            c++;
                            break;
                        }
                    }
                }
            }
        }
        //選項設定 END
    }
    //Get
    public static Question_Class Question_Get(int n)
    {
        return question_temp[n];
    }
    public static string GetButton_Ans(int c)
    {
        return Button_Ans[c];
    }
    //Change
    public static void ChangeButton_Ans(string s, int c) //傳送到Level_Learn的三個選項
    {
        Text t_temp;
        t_temp = GameObject.Find("Text_Ans-" + (c+1).ToString()).GetComponent<Text>();
        t_temp.text = s;
        Button_Ans[c]=s;
    }
    // Level_Learn
    public static void ChangeAnswer_r(string s, int c)
    {
        question_temp[c].ChangeAnswer_r(s);
    }
    public static void ChangeAnswer_c(string s, int c)
    {
        question_temp[c].ChangeAnswer_c(s);
    }
    public static void ChangeAnswer_c_Content(string s, int c)
    {
        question_temp[c].ChangeAnswer_c_Content(s);
    }
    public static void ChangeFeedBack(string s, int c)
    {
        question_temp[c].ChangeFeedBack(s);
    }
    //Overall
    public static Question_Class Question_Overall_Get(int n)
    {
        return question_overall_temp[n];
    }
    public static Question_Class Question_Overall_Get_E(int n)
    {
        return question_overall_temp_E[n];
    }
    public static void ChangeAnswer_c_Content_O(string s, int c)
    {
        question_overall_temp[c].ChangeAnswer_c_Content(s);
    }
    public static void ChangeFeedBack_O(string s, int c)
    {
        question_overall_temp[c].ChangeFeedBack(s);
    }
    //亂數函式
    public static int[] GetRandomSequence(int total)
    {
        int r;
        int[] output = new int[total];
        for (int i = 0; i < total; i++)
        {
            output[i] = i;
        }
        for (int i = 0; i < total; i++)
        {
            r = Random.Range(0, total);
            int temp = 0;
            temp = output[i];
            output[i] = output[r];
            output[r] = temp;
        }
        return output;
    }
    public static void QaARandomSequence(int total)
    {
        int r;
        for (int i = 0; i < total; i++)
        {
            r = Random.Range(0, total);
            string temp = "";
            temp = Question[i];
            Question[i] = Question[r];
            Question[r] = temp;

            temp = Answer_r_Content[i];
            Answer_r_Content[i] = Answer_r_Content[r];
            Answer_r_Content[r] = temp;
        }
    }
    public static void O_QaARandomSequence(int total) //Overall
    {
        int r;
        for (int i = 0; i < total; i++)
        {
            r = Random.Range(0, total);
            string temp = "";
            temp = O_Question[i];
            O_Question[i] = O_Question[r];
            O_Question[r] = temp;

            temp = O_Answer_r_Content[i];
            O_Answer_r_Content[i] = O_Answer_r_Content[r];
            O_Answer_r_Content[r] = temp;

            temp = O_Question_E[i];
            O_Question_E[i] = O_Question_E[r];
            O_Question_E[r] = temp;
        }
    }
    
}
