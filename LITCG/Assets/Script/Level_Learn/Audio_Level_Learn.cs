using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_Level_Learn : MonoBehaviour {
    public AudioSource access; //access
    public AudioSource ashamed; //ashamed
    public AudioSource authority; //authority
    public AudioSource bare; //bare
    public AudioSource behavior; //behavior
    public AudioSource citizen; //citizen
    public AudioSource clash; //clash
    public AudioSource destroy; //destroy
    public AudioSource exhaust; //exhaust
    public AudioSource fort; //fort

    public AudioSource graceful; //graceful
    public AudioSource invade; //invade
    public AudioSource mystery; //mystery
    public AudioSource occupy; //occupy
    public AudioSource restrict; //restrict
    public AudioSource security; //security
    public AudioSource toss; //toss
    public AudioSource troop; //troop
    public AudioSource vary; //vary
    public AudioSource wicked; //wicked

    public void Voice()
    {
        if (Level_Check.choose < 3)
            Play();
    }
    public void Play()
    {
        Question_Class[] question_temp = new Question_Class[Question_Check.Question_total];
        for (int i = 0; i < Question_Check.Question_total; i++) {
            question_temp[i] = Question_Data.Question_Get(i);
        }
        question_temp[Question_Check.Question_Num].GetQuestion();

        switch ( question_temp[Question_Check.Question_Num].GetQuestion() ) 
        {
            case "access":
                access.Play();
                break;
            case "ashamed":
                ashamed.Play();
                break;
            case "authority":
                authority.Play();
                break;
            case "bare":
                bare.Play();
                break;
            case "behavior":
                behavior.Play();
                break;
            case "citizen":
                citizen.Play();
                break;
            case "clash":
                clash.Play();
                break;
            case "destroy":
                destroy.Play();
                break;
            case "exhaust":
                exhaust.Play();
                break;
            case "fort":
                fort.Play();
                break;
            case "graceful":
                graceful.Play();
                break;
            case "invade":
                invade.Play();
                break;
            case "mystery":
                mystery.Play();
                break;
            case "occupy":
                occupy.Play();
                break;
            case "restrict":
                restrict.Play();
                break;
            case "security":
                security.Play();
                break;
            case "toss":
                toss.Play();
                break;
            case "troop":
                troop.Play();
                break;
            case "vary":
                vary.Play();
                break;
            case "wicked":
                wicked.Play();
                break;
            default:
                break;
        }
    }
}
