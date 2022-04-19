using UnityEngine;
using UnityEngine.UI;

public class GamePlay : MonoBehaviour
{
    public GameStateManager gameStateManager;
    public GameObject pauseButton;
    public GameObject resume;
    public GameObject score;
    public Rigidbody2D playerRigidbody;
   


    public void OnclickPlay()
    {
        if (gameStateManager.GamePlay != null)
        {
            gameStateManager.GamePlay();
            pauseButton.SetActive(true);
            score.SetActive(true);
        }
        gameStateManager.currentGameState = GameState.Play;


    }
    public void Pause()
    {
        resume.SetActive(true);
        playerRigidbody.constraints = RigidbodyConstraints2D.FreezeAll;
    }


    public void Resume()
    {
        resume.SetActive(false);
        playerRigidbody.constraints = RigidbodyConstraints2D.None;
    }
}
