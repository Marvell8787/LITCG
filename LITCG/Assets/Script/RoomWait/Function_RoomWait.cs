using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Function_RoomWait : MonoBehaviour {

    public void Back()
    {
        Application.LoadLevel("Battle");
    }

    public void Play()
    {
        Player_Data.Player_Init();
        Application.LoadLevel("RoomFight");
    }
}
