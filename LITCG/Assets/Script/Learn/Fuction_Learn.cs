using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuction_Learn : MonoBehaviour {
    public void GoMaterial()
    {
        Application.LoadLevel("Material");
    }
    public void GoLevel()
    {
        Application.LoadLevel("Level");
    }
    public void Back()
    {
        Application.LoadLevel("Home");
    }

}
