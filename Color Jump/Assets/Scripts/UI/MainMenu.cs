using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameStateManager gameStateManager;
    
   

    public void OnClickToMainMenu()
    {
        if(gameStateManager.GamePlay !=null)
        {
            gameStateManager.MainMenu();
        }
            gameStateManager.currentGameState = GameState.MainMenu;
       
    }

}
