using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_Material : MonoBehaviour {
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
    // Use this for initialization
    public void Play()
    {
        switch (Material_Check.Choose + Material_Check.ten)
        {
            case 0:
                access.Play();
                break;
            case 1:
                ashamed.Play();
                break;
            case 2:
                authority.Play();
                break;
            case 3:
                bare.Play();
                break;
            case 4:
                behavior.Play();
                break;
            case 5:
                citizen.Play();
                break;
            case 6:
                clash.Play();
                break;
            case 7:
                destroy.Play();
                break;
            case 8:
                exhaust.Play();
                break;
            case 9:
                fort.Play();
                break;
            case 10:
                graceful.Play();
                break;
            case 11:
                invade.Play();
                break;
            case 12:
                mystery.Play();
                break;
            case 13:
                occupy.Play();
                break;
            case 14:
                restrict.Play();
                break;
            case 15:
                security.Play();
                break;
            case 16:
                toss.Play();
                break;
            case 17:
                troop.Play();
                break;
            case 18:
                vary.Play();
                break;
            case 19:
                wicked.Play();
                break;
            default:
                break;
        }
    }
}
