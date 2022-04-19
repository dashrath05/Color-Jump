using UnityEngine;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public int Score;
    public int highScore;
    public Text showScore;
  

    private void Awake()
    {
        instance = this;
    }


    public void HighScore()
    {
        if(Score>=PlayerPrefs.GetInt("HighScore",0))
        {
            PlayerPrefs.SetInt("HighScore", Score);
        }
    }

   

    public void ScoreIncrease()
    {
        Score += 1;
        showScore.text = Score.ToString();

    }

    

    public void ScoreRemove()
    {
        showScore.text = Score.ToString();
    }

    
}
