using UnityEngine;
using UnityEngine.UI;

public class PlayerColor : MonoBehaviour
{
    public Image playerRenderer;
    public Text highScore;
    public RBlockColorProvider rightBlockColorProvider;
    public LBlockColorProvider leftBlockColorProvider;


    private void Start()
    {
        AllColorProvider();
    }

    public void AllColorProvider()
    {

        highScore.text = PlayerPrefs.GetInt("HighScore").ToString();

       
            // give left side random color
            leftBlockColorProvider.RandomColor();

            // give right side random color
            rightBlockColorProvider.RandomColor();

            //give player color
            ChangePlayerColor();
       
    }


    public void ChangePlayerColor()
    {

       
            int randomNumber2 = Random.Range(0, rightBlockColorProvider.ColorName.Count);
            string colorName2 = rightBlockColorProvider.ColorName[randomNumber2];
            //Give Player random color
            playerRenderer.color = ColorProvider.instance.FindColor(colorName2);
    }

    
}
