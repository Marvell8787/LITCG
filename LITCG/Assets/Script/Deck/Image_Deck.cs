using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Image_Deck : MonoBehaviour {



    public void Card_0()
    {
        Image I_Temp;
        I_Temp = GameObject.Find("Image_Card_0").GetComponent<Image>();
        I_Temp.sprite = Resources.Load("Image/Show", typeof(Sprite)) as Sprite;
    }
    public void Card_1()
    {

    }
}
