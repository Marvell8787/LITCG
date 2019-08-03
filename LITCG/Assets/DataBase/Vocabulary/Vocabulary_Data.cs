using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static class Vocabulary_Data{
    private static string[] Vocabulary_E_Name = new string[20] { "implement", "helmet", "assurance", "lord", "contribute", "depth", "luxury", "applause", "marathon", "electronic", "a" ,"b", "c", "d", "e", "f", "g","h", "i","j" };
    private static string[] Vocabulary_C_Name = new string[20] { "實行", "頭盔", "保證;把握", "統治者", "貢獻", "深度", "奢侈","掌聲","馬拉松","電子的", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j" };
    private static string[] Vocabulary_Voice = new string[20] { "implement" ,"helmet", "assurance", "lord", "contribute", "depth", "luxury","applause", "marathon","electronic", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j" };
    private static string[] Vocabulary_PartOfSpeech = new string[20] { "n.名詞;v.動詞", "n.名詞", "n.名詞", "n.名詞", "v.動詞", "n.名詞", "n.名詞", "n.名詞", "n.名詞", "adj.形容詞", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j" };

    public static Vocabulary_Class[] vocabulary_temp = new Vocabulary_Class[20];

    public static void Vocabulary_Init()
    {
        for (int i = 0; i < 20; i++)
        {
            vocabulary_temp[i] = new Vocabulary_Class(Vocabulary_E_Name[i], Vocabulary_C_Name[i], Vocabulary_Voice[i], Vocabulary_PartOfSpeech[i]);
        }
    }
    public static Vocabulary_Class Vocabulary_Get(int n)
    {
        return vocabulary_temp[n];
    }

}
