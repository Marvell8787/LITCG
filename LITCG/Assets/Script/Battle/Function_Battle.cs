using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static class Enemy{
    public static int No = 0;
}

public class Function_Battle : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Battle1()
    {
        Enemy.No = 1;
        Application.LoadLevel("RoomWait");
    }
    public void Battle2()
    {
        Enemy.No = 2;
        Application.LoadLevel("RoomWait");
    }
    public void Battle3()
    {
        Enemy.No = 3;
        Application.LoadLevel("RoomWait");
    }
    public void Back()
    {
        Application.LoadLevel("Home");
    }
}
