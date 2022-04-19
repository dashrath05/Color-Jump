using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameStateManager gameStateManager;
    public PlayerMovement playerMovement;
    public LBlockColorProvider LBlockColorProvider;
    public PlayerColor playerColor;

    
    public void Gameover()
    {
        
        if(gameStateManager.GamePlay != null)
        {
            gameStateManager.Gameover();
            playerMovement.PlayerFreeze();
        }
        gameStateManager.currentGameState = GameState.Gameover;
    }


    public void RestartGame()
    {
        playerMovement.PlayerUnfreeze();
        playerColor.AllColorProvider();
        gameStateManager.MainMenu();
        gameStateManager.currentGameState = GameState.MainMenu;
    }
        
    
}
