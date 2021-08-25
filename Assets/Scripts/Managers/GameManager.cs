using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private LevelGenerationManager levelGenerationManager;
    private StateManager stateManager;
    private GameDataManager gameDataManager;
    private BoardManager boardManager;

    void Start()
    {
        preloadComponents();
        loadBoardPatterns();
    }

    void Update()
    {

    }

    private void preloadComponents()
    {
        levelGenerationManager = GetComponent<LevelGenerationManager>();
        stateManager = GetComponent<StateManager>();
        gameDataManager = GetComponent<GameDataManager>();
        GameObject gameViewUi = GameObject.FindGameObjectWithTag("UiGameViewTag");
        boardManager = gameViewUi.GetComponent<BoardManager>();
    }

    private void loadBoardPatterns()
    {
        levelGenerationManager.parsePatternFile();
    }

    public void startGame()
    {
        print("GameManager: start game");
        boardManager.setUpLevelBoard(levelGenerationManager.getLevel(Sudoku.Difficulty.SIMPLE));
        stateManager.emitState(Sudoku.GameState.IN_GAME);
    }

    public void pauseGame()
    {
        print("GameManager: game paused");
        stateManager.emitState(Sudoku.GameState.IN_PAUSE_MENU);
    }

    public void quitGame()
    {
        print("GameManager: game quit");
        stateManager.emitState(Sudoku.GameState.IN_MENU);
    }

    public void resumeGame()
    {
        print("GameManager: game resume");
        stateManager.emitState(Sudoku.GameState.IN_RESUME);
    }

    public void restartGame()
    {
        print("GameManager: game restart");
        stateManager.emitState(Sudoku.GameState.IN_RESTART);
    }

    public void onTileRelease()
    {
        stateManager.emitState(Sudoku.GameState.IN_MOVABLE_TILE_RELEASE);
    }
}
