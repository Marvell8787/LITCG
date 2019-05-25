using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Function_Home : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    public void Task()
    {
        //Application.LoadLevel("Task");
    }
    public void Learn()
    {
        //Application.LoadLevel("Learn");
    }
    public void Deck()
    {
        Application.LoadLevel("Deck");
    }
    public void Battle()
    {
        //Application.LoadLevel("Battle");
    }
    public void Shop()
    {
        Application.LoadLevel("Shop");
    }
    public void Profile()
    {
        Application.LoadLevel("Profile");
    }
    public void Introduction()
    {
        Application.LoadLevel("Introduction");
    }

}
