using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Function_Profile : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    public void Back()
    {
        SceneManager.LoadScene("Home");
    }

}
