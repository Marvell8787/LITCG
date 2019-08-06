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
        Player_Data.Shuffle(0);
        Player_Data.Shuffle(1);
        Player_Data.Deal();
        Application.LoadLevel("RoomFight");
    }
}
