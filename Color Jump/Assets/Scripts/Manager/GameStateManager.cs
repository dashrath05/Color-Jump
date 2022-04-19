using UnityEngine;
using System;

public class GameStateManager : MonoBehaviour
{

    public GameState currentGameState = GameState.MainMenu;


    public Action MainMenu;
    public Action GamePlay;
    public Action Gameover;
    
}
