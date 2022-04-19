using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeftColorCheck : MonoBehaviour
{ 

    public LBlockColorProvider leftBlockColor;
    public RBlockColorProvider rightBlockColor;
    public PlayerColor playerColor;
    public Image spriteRenderer;
    public PlayerMovement playerMovement;
    public GameStateManager gameStateManager;
    


   

    private void OnCollisionEnter2D(Collision2D collision)
    {
      
        if (collision.collider.tag == "Player")
        {
            
            if (playerColor.playerRenderer.color == spriteRenderer.color)
            {
                ChangeColor();
                SoundManager.instance.BounceBall();

                ScoreManager.instance.ScoreIncrease();
                playerMovement.GivePlayerForce(100,500);
                playerMovement.playerSideForce = 400;
                
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

        int randomNumber = Random.Range(0, rightBlockColor.ColorName.Count);
        string colorName = rightBlockColor.ColorName[randomNumber];
        //Give Player random color
        playerColor.playerRenderer.color = ColorProvider.instance.FindColor(colorName);
        //Give right block random color
        leftBlockColor.RandomColor();
    }
}
