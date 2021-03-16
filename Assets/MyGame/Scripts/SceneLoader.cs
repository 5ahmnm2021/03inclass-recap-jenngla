using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader: MonoBehaviour
{
    public void Load01()
    {
        // from 00 to 01
        SceneManager.LoadScene("01_ColorScene");
    }

    public void Re_Load00()
    {
        // from 01 back to 00
        SceneManager.LoadScene("00_WelcomeScene");
    }

    public void Load02()
    {
        // from 01 to 02
        SceneManager.LoadScene("02_NumberScene");
    }

    public void Re_Load01()
    {
        // from 02 back to 01
        SceneManager.LoadScene("01_ColorScene");
    }

    public void Load00()
    {
        // from 02 back to 00
        SceneManager.LoadScene("00_WelcomeScene");
    }

}
