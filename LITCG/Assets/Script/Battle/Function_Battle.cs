using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Function_Battle : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void RoomWait()
    {
        Application.LoadLevel("RoomWait");
    }
    public void Back()
    {
        Application.LoadLevel("Home");
    }
}
