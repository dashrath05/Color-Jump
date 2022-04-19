using UnityEngine;
using UnityEngine.UI;


public class UIManager : MonoBehaviour
{
    public GameStateManager stateManager;
    public PlayerMovement playerMovement;
    public GamePlay gamePlay;
    public GameObject score;
    public GameObject pause;
    public Text highScore;
    public Text finalScore;

    public Canvas gameoverCanvas;
    public Canvas mainMenuCanvas;
    public Canvas gameplayCanvas;



    private void Start()
    {
        stateManager.Gameover += ActiveGameoverCanvas;
        stateManager.MainMenu += ActiveMainMenu;
        stateManager.GamePlay += ActiveGamePlay;
    }

    public void ActiveGameoverCanvas()
    {

        gameoverCanvas.enabled = true;
        gameplayCanvas.enabled = false;
        mainMenuCanvas.enabled = false;
        playerMovement.playerRigidbody.gravityScale = 0;
        playerMovement.playerRigidbody.velocity = Vector2.zero;
        gamePlay.playerRigidbody.constraints = RigidbodyConstraints2D.FreezeAll;
        highScore.text = PlayerPrefs.GetInt("HighScore").ToString();
        finalScore.text = ScoreManager.instance.Score.ToString();
        //Game over then score zero
        ScoreManager.instance.Score = 0;
    }

    public void ActiveMainMenu()
    {
        mainMenuCanvas.enabled = true;
        gameoverCanvas.enabled = false;
        gameplayCanvas.enabled = true;
        score.SetActive(false);
        pause.SetActive(false);
        playerMovement.playerRigidbody.gravityScale = 0;
        playerMovement.playerRigidbody.velocity = Vector2.zero;
        gamePlay.playerRigidbody.constraints = RigidbodyConstraints2D.FreezeAll;
        ScoreManager.instance.Score = 0;
        ScoreManager.instance.ScoreRemove();
    }

    public void ActiveGamePlay()
    {
        gameplayCanvas.enabled = true;
        mainMenuCanvas.enabled = false;
        gamePlay.playerRigidbody.constraints = RigidbodyConstraints2D.None;
        playerMovement.playerRigidbody.gravityScale = 400f;
        
    }
}