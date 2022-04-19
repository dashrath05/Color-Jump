using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class RBlockColorProvider : MonoBehaviour
{
    public Image[] allImage;
    public int previousColorIndex;
    public List<string> ColorName = new List<string>();



    //give Random color to all Sprites
    public void RandomColor()
    {
        if (ColorName != null)
        {
            ColorName.Clear();
        }


        for (int i = 0; i < allImage.Length; i++)
        {
            //choose random color Index
            int colorIndex = Random.Range(0, allImage.Length);
            if (previousColorIndex != colorIndex)
            {
                allImage[i].color = ColorProvider.instance.ColorParsing((COLOR)colorIndex);
                previousColorIndex = colorIndex;
                ColorName.Add(((COLOR)colorIndex).ToString());
            }
            else
            {
                allImage[i].color = ColorProvider.instance.ColorParsing((COLOR)colorIndex + 1);
                previousColorIndex = colorIndex + 1;
                ColorName.Add(((COLOR)colorIndex + 1).ToString());
            }
        }

    }
}
