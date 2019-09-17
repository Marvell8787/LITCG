using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Function_RoomWait : MonoBehaviour {

    public void Back()
    {
        SceneManager.LoadScene("Battle");
    }
    public void Challenge()
    {
        BattleCheck.challenge = 1;
        Play();
    }
    public void Play()
    {
        Player_Data.Player_Init();
        Player_Data.Shuffle(0);
        Player_Data.Shuffle(1);
        Player_Data.Deal();
        SceneManager.LoadScene("RoomFight");
    }
}
