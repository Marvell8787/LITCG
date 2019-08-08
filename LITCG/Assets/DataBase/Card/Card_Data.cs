using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static class Card_Data{

    private static string[] Card_CType = new string[22];
    private static string[] Card_Picture = new string[22] { "fool", "magician", "high-priestess", "empress", "emperor", "hierophant", "lovers", "chariot", "strength", "hermit", "fortune-wheel", "justice", "hanged-man", "death", "temperance", "devil", "tower", "stars", "moon", "sun", "judgement", "world" };
    private static string[] Card_Name = new string[22] { "The FOOL", "The MAGICIAN", "The HIGH PRIESTESS", "The EMPRESS", "The EMPEROR", "The HIEROPHANT", "THE LOVERS", "THE CHARIOT" ,"STRENGTH", "THE HERMIT", "WHEEL OF FORTUNE", "THE JUSTICE", "THE HANGED MAN", "THE DEATH", "THE TEMPERANCE", "THE DEVIL", "THE TOWER", "THE START", "THE MOON", "The SUN", "THE JUDGEMENT", "THE WORLD" };
    private static string[] Card_Rarity = new string[22] { "N","N","N","N","N","N","N","R", "R", "R","R", "R", "SR", "SR" ,"SSR", "R", "R", "SR", "SSR", "SR", "SR", "SSR" };
    private static string[] Card_Description = new string[22];
    private static int[] Card_ATK = new int[22] { 1, 1, 1, 1, 2, 2, 2, 2, 3, 3, 3, 3, 4,4,5,3,5,8,0,0,0,0 }; //+3 +5 8
    private static string[] Card_Effect = new string[22];

    private static Card_Class[] card_temp = new Card_Class[22];

    public static void Card_Init()
    {
        for(int i = 0; i < 22; i++)
        {
            if (i < 15)
                Card_CType[i] = "Fight";
            else if (i > 14 & i < 19)
                Card_CType[i] = "Magic";
            else if (i >18)
                Card_CType[i] = "Support";
        }
        for (int i = 0; i < 22; i++)
        {
            switch (i)
            {
                //Fight
                case 0: Card_Effect[i] = "Fight ATK = 1"; break;
                case 1: Card_Effect[i] = "Fight ATK = 1"; break;
                case 2: Card_Effect[i] = "Fight ATK = 1"; break;
                case 3: Card_Effect[i] = "Fight ATK = 1"; break;
                case 4: Card_Effect[i] = "Fight ATK = 2"; break;
                case 5: Card_Effect[i] = "Fight ATK = 2"; break;
                case 6: Card_Effect[i] = "Fight ATK = 2"; break;
                case 7: Card_Effect[i] = "Fight ATK = 2"; break;
                case 8: Card_Effect[i] = "Fight ATK = 3"; break;
                case 9: Card_Effect[i] = "Fight ATK = 3"; break;
                case 10:Card_Effect[i] = "Fight ATK = 3"; break;
                case 11:Card_Effect[i] = "Fight ATK = 3"; break;
                case 12:Card_Effect[i] = "Fight ATK = 4"; break;
                case 13:Card_Effect[i] = "Fight ATK = 4"; break;
                case 14: Card_Effect[i] = "Fight ATK = 5"; break;
                //Magic
                case 15: Card_Effect[i] = "A Fight ATK + 3"; break;
                case 16: Card_Effect[i] = "A Fight ATK + 5"; break;
                case 17: Card_Effect[i] = "A Fight ATK = 8"; break;
                case 18: Card_Effect[i] = "B Fight ATK = 1"; break; //moon
                    //Support
                case 19: Card_Effect[i] = "A B Player LP + 2"; break; //sun
                case 20: Card_Effect[i] = "A B Player LP + 3"; break; //judgement
                case 21: Card_Effect[i] = "A Player LP + 5"; break; //world
                default: Card_Effect[i] = "#"; break;
            }

        }

        for (int i = 0; i < 22; i++)
        {
            card_temp[i] = new Card_Class(Card_CType[i],Card_Picture[i], Card_Name[i], Card_Rarity[i],"", Card_ATK[i], Card_Effect[i]);
        }

    }

    public static Card_Class Card_Get(int n)
    {
        return card_temp[n];
    }
}
