using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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
        SceneManager.LoadScene("RoomWait");
    }
    public void Battle2()
    {
        Enemy.No = 2;
        SceneManager.LoadScene("RoomWait");
    }
    public void Battle3()
    {
        Enemy.No = 3;
        SceneManager.LoadScene("RoomWait");
    }
    public void Back()
    {
        SceneManager.LoadScene("Home");
    }
}
