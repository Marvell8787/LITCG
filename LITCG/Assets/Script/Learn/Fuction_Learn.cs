using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Fuction_Learn : MonoBehaviour {
    public void GoMaterial()
    {
        SceneManager.LoadScene("Material");
    }
    public void GoLevel()
    {
        SceneManager.LoadScene("Level");
    }
    public void Back()
    {
        SceneManager.LoadScene("Home");
    }

}
