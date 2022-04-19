using UnityEngine;
using UnityEngine.UI;

public class RightColorCheck : MonoBehaviour
{
    public LBlockColorProvider leftBlockColor;
    public RBlockColorProvider rightBlockColor;
    public PlayerColor playerColor;
    public Image spriteRenderer;
    public PlayerMovement playerMovement;
    public GameStateManager gameStateManager;


    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.R))
        {
            ChangeColor();
        }

        

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       /* Debug.Log("collide");*/
        if (collision.collider.tag == "Player")
        {

            if (playerColor.playerRenderer.color == spriteRenderer.color)
            {
                SoundManager.instance.BounceBall();
                ChangeColor();
                ScoreManager.instance.ScoreIncrease();
                ScoreManager.instance.HighScore();
                playerMovement.GivePlayerForce(-100,500);
                playerMovement.playerSideForce = -400;
               
            }

            else
            {
                //gameover
                gameStateManager.Gameover();
                gameStateManager.currentGameState = GameState.Gameover;
                SoundManager.instance.BallBlast();
            }
        }
    }


    public void ChangeColor()
    {

        int randomNumber = Random.Range(0, leftBlockColor.ColorName.Count);
        string colorName = leftBlockColor.ColorName[randomNumber];
        //Give Player random color
        playerColor.playerRenderer.color = ColorProvider.instance.FindColor(colorName);
        //Give right block random color
        rightBlockColor.RandomColor();
    }

}
