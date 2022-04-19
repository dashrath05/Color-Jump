using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ColorProvider : MonoBehaviour
{
    Color curretColor;
    Color finalColor;
    
    public static ColorProvider instance;

      
    private void Awake()
    {
        if(instance==null)
            instance = this;
    }
       
    public Color ColorParsing(COLOR availableColor)
    {

        switch (availableColor)
        {
            case COLOR.Blue:
                curretColor = Color.blue;
                break;


            case COLOR.Green:
                curretColor = Color.green;
                break;

            case COLOR.Red:
                curretColor = Color.red;
                break;

            case COLOR.Yellow:
                curretColor = Color.yellow;
                break;

            default:
                break;
        }
        return curretColor;

    }
    public Color FindColor(string colorName)
    {

        switch (colorName)
        {
            case "Blue":
                finalColor = Color.blue;
                break;


            case "Green":
                finalColor = Color.green;
                break;

            case "Red":
                finalColor = Color.red;
                break;

            case "Yellow":
                finalColor = Color.yellow;
                break;

            default:
                break;
        }
        return finalColor;

    }




}
