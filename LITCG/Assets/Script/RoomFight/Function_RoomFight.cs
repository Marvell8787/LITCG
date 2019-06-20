using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Function_RoomFight : MonoBehaviour {

	public void Win()
    {
        Learner_Data.Learner_Add("Battle_Win", 1);
        Application.LoadLevel("Settlement_Battle");
    }
    public void Lose()
    {
        Learner_Data.Learner_Add("Battle_Lose", 1);
        Application.LoadLevel("Settlement_Battle");
    }
}
