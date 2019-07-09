using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Player_Class{
    private int LP = 0;
    private int[] Deck_Status = new int[22] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }; //卡片持有狀態 0:無(本來就沒有) 1:有(持有) 2:持有但已抽掉 
    private int Deck_Num = 0;
    private int Deck_Draw = 0; //已抽取牌數
    private int Hand = 0;
    private int State = 0; // 0:No 1:Ok

    public Player_Class(int _LP = 0, int _Deck_Num = 0, int _Hand = 0, int _State = 0)
    {
        LP = _LP;
        Deck_Num = _Deck_Num;
        Hand = _Hand;
        State = _State;
    }
    public int GetLP()
    {
        return LP;
    }
    public int GetDeck_Status(int n)
    {
        return Deck_Status[n];
    }
    public int GetDeck_Num()
    {
        return Deck_Num;
    }
    public int GetHand()
    {
        return Hand;
    }
    public int GetState()
    {
        return State;
    }
    public void ChangeLP(int n)
    {
        LP -= n;
    }
    public int[] ChangeDeck_Status(int s, int n) //s=索引值 n=值
    {
        Deck_Status[s] = n;
        return Deck_Status;
    }
    public void ChangeDeck_Num(int n)
    {
        Deck_Num -= n;
    }
    public void ChangeHand(int n)
    {
        Hand -= n;
    }
    public void ChangeState(int n)
    {
        State = n;
    }
}
