using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{
    public InputField Number1_field;
    public InputField Number2_field;

    float num1;
    float num2;

    public Text result;

    bool bool1 = false;
    public bool bool2 = false;

    public void tryandcattch_num1()
    {

        try
        {
            num1 = float.Parse(Number1_field.text);
            bool1 = true;
        }
        catch (System.Exception)
        {
            Number1_field.image.color = new Color32(255, 25, 25, 100);
            bool1 = false;
        }
    }

    public void tryandcattch_num2()
    {
        try
        {
            num2 = float.Parse(Number2_field.text);
            bool2 = true;
        }
        catch (System.Exception)
        {
            Number2_field.image.color = new Color32(255, 25, 25, 100);
            bool2 = false;
        }
    }

    private void Update()
    {
        if (bool1 == true && bool2 == true)
        {
            float addResult = num1 + num2;
            result.text = addResult.ToString();
        }

        else
        {
            result.text = "Wrong input";
        }
    }
}
