using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChange : MonoBehaviour
{
    public GameObject color;

    public void ChangeColor()
    {
        Color[] colors =
        {
            new Color32(255, 240, 50, 100),     // yellow-ish green
            new Color32(200, 0, 0, 100),        // red
            new Color32(50, 50, 255, 100),      // purple
            new Color32(35, 200, 235, 100),     // blue
        };

        if(Input.GetKeyDown("space"))
        {
            color.GetComponent<Image>().color = colors[Random.Range(0, colors.Length)];
        }
    }

    void Update()
    {
        ChangeColor();
    }
}
