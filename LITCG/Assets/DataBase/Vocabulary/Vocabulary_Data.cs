using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static class Vocabulary_Data{
    private static string[] Vocabulary_E_Name = new string[10] { "implement" ,"helmet", "assurance", "lord", "contribute", "depth", "luxury","applause", "marathon","electronic" };
    private static string[] Vocabulary_C_Name = new string[10] { "實行", "頭盔", "保證;把握", "統治者", "貢獻", "深度", "奢侈","掌聲","馬拉松","電子的" };
    private static string[] Vocabulary_Voice = new string[10] { "implement" ,"helmet", "assurance", "lord", "contribute", "depth", "luxury","applause", "marathon","electronic" };
    private static string[] Vocabulary_PartOfSpeech = new string[10] { "n.名詞;v.動詞", "n.名詞", "n.名詞", "n.名詞", "v.動詞", "n.名詞", "n.名詞", "n.名詞", "n.名詞", "adj.形容詞" };
    private static string[] Vocabulary_Sentence = new string[10];

    public static Vocabulary_Class[] vocabulary_temp = new Vocabulary_Class[10];

    public static void Vocabulary_Init()
    {
        Vocabulary_Sentence[0] = "The government implemented new policies last year."; //implement
        Vocabulary_Sentence[1] = "Everyone must wear a helmet when riding a motorcycle."; //helmet
        Vocabulary_Sentence[2] = "The doctor made an assurance that my mom’s disease will be cured."; //assirance
        Vocabulary_Sentence[3] = "The lord of the manor must have had many privileges. "; //lord
        Vocabulary_Sentence[4] = "He contributed many ideas to the renovation plans."; //contirbute
        Vocabulary_Sentence[5] = "The depth of the sea cannot be measured."; //depth
        Vocabulary_Sentence[6] = "Anna lived in the lap of luxury."; //luxury
        Vocabulary_Sentence[7] = "Please give an applause to welcome the philanthropist."; //applause
        Vocabulary_Sentence[8] = "We will run a marathon next week."; //marathon
        Vocabulary_Sentence[9] = "We have a lot of electronic devices in the house."; //electronic
        for (int i = 0; i < 10; i++)
        {
            vocabulary_temp[i] = new Vocabulary_Class(Vocabulary_E_Name[i], Vocabulary_C_Name[i], Vocabulary_Voice[i], Vocabulary_PartOfSpeech[i], Vocabulary_Sentence[i]);
        }
    }
    public static Vocabulary_Class Vocabulary_Get(int n)
    {
        return vocabulary_temp[n];
    }

}
