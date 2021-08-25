using UnityEngine;

public class StateManager : MonoBehaviour
{
    private GameManagedObject[] gameManagedObjects;
    private Sudoku.GameState gameState = Sudoku.GameState.IN_MENU;

    void Start()
    {
        init();
    }

    private void init()
    {
        findGameManagedObjects();
    }

    private void findGameManagedObjects()
    {
        gameManagedObjects = UnityEngine.Object.FindObjectsOfType<GameManagedObject>();
        print("StateManager: game managed objects founded.");
    }

    public void emitState(Sudoku.GameState state)
    {
        gameState = state;
        for (int i = 0; i < gameManagedObjects.Length; i++) {
            gameManagedObjects[i].onGameState(state);
            print("state emitted: " + state);
        }
    }

    public Sudoku.GameState getState()
    {
        return gameState;
    }
}