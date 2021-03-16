using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{
    public InputField number1_field;
    public InputField number2_field;

    float num1;
    float num2;

    public Text result;

    bool bool1 = false;
    public bool bool2 = false;

    public void TryandCatch_num1()
    {
        try
        {
            num1 = float.Parse(number1_field.text);
            bool1 = true;
        }
        catch (System.Exception)
        {
            number1_field.image.color = new Color32(255, 25, 25, 100);
            bool1 = false;
        }
    }

    public void TryandCatch_num2()
    {
        try
        {
            num2 = float.Parse(number2_field.text);
            bool2 = true;
        }
        catch (System.Exception)
        {
            number2_field.image.color = new Color32(255, 25, 25, 100);
            bool2 = false;
        }
    }

    private void Update()
    {
        if (bool1 == true && bool2 == true)
        {
            number1_field.image.color = new Color32(255, 255, 255, 255);
            number2_field.image.color = new Color32(255, 255, 255, 255);
            float addResult = num1 + num2;
            result.text = addResult.ToString();
        }

        else
        {
            result.text = "invalid";
        }

    }
}
