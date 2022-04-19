using UnityEngine;

public class CheckBoundary : MonoBehaviour
{

    public GameStateManager gameStateManager;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.collider.tag == "Player")
        {
            gameStateManager.Gameover();

            //Debug.Log("gameover");
            gameStateManager.currentGameState = GameState.Gameover;
        }
    }
}
