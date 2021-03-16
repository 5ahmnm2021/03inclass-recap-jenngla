using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{
    public InputField number1_field;
    public InputField number2_field;

    private float num1;
    private float num2;

    public Text empty1;
    public Text empty2;

    public Text result;

    private bool bool1 = true;
    private bool bool2 = true;

    public void TryandCatch_num1()
    {
       
        try
        {
            num1 = float.Parse(number1_field.text);
            bool1 = true;
            number1_field.image.color = new Color32(255, 255, 255, 255);
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
            number2_field.image.color = new Color32(255, 255, 255, 255);
        }
        catch (System.Exception)
        {
            number2_field.image.color = new Color32(255, 25, 25, 100);
            bool2 = false;
        }
    }

    private void Update()
    {
        if (empty1.text.Equals(""))
        {
            number1_field.image.color = new Color32(255, 255, 255, 255);
        }
        else
        { }

        if (empty2.text.Equals(""))
        {
            number2_field.image.color = new Color32(255, 255, 255, 255);
        }
        else
        { }

        if (bool1 == true && bool2 == true)
        {

            float addResult = num1 + num2;
            result.text = addResult.ToString();
        }
        else
        {
            result.text = "error";
        }
    }
}
