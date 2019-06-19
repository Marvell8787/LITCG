using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Function_Guide : MonoBehaviour {

	public void Task () {
        Text T_Temp;
        T_Temp = GameObject.Find("Text_Content").GetComponent<Text>();
        T_Temp.text = "";
	}
    public void Learn(){
        Text T_Temp;
        T_Temp = GameObject.Find("Text_Content").GetComponent<Text>();
        T_Temp.text = "";
    }
    public void Battle()
    {

    }
    public void Status()
    {

    }

}
