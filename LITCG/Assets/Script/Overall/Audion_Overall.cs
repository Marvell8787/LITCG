using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audion_Overall : MonoBehaviour {
    public AudioSource implement; //implement
    public AudioSource helmet; //helmet
    public AudioSource assurance; //assurance
    public AudioSource lord; //lord
    public AudioSource contribute; //contribute
    public AudioSource depth; //depth
    public AudioSource luxury; //luxury
    public AudioSource applause; //applause
    public AudioSource marathon; //marathon
    public AudioSource electronic; //electronic

    public void Play()
    {
        Question_Class[] question_temp = new Question_Class[20];
        for (int i = 0; i < 20; i++)
        {
            question_temp[i] = Question_Data.Question_Overall_Get_E(i);
        }
        question_temp[Question_Check.Question_Num].GetQuestion();

        switch (question_temp[Question_Check.Question_Num].GetQuestion()) 
        {
            case "implement":
                implement.Play();
                break;
            case "helmet":
                helmet.Play();
                break;
            case "assurance":
                assurance.Play();
                break;
            case "lord":
                lord.Play();
                break;
            case "contribute":
                contribute.Play();
                break;
            case "depth":
                depth.Play();
                break;
            case "luxury":
                luxury.Play();
                break;
            case "applause":
                applause.Play();
                break;
            case "marathon":
                marathon.Play();
                break;
            case "electronic":
                electronic.Play();
                break;
            default:
                break;
        }
    }
}
