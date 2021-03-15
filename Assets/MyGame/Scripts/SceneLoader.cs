using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader: MonoBehaviour
{
    public void SceneSwitcher12()
    {
        SceneManager.LoadScene("01_ColorScene");
    }
    public void SceneSwitcher23()
    {
        SceneManager.LoadScene("02_NumberScene");
    }
    public void SceneSwitcher31()
    {
        SceneManager.LoadScene("00_WelcomeScene");
    }
}
