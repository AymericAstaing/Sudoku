using UnityEngine;

public interface IGameManagedObject
{
    void initRootConnection();
    void onStart();
    void onGameState(Sudoku.GameState state);
}

public class GameManagedObject : MonoBehaviour, IGameManagedObject
{
    protected GameManager gManager;

    void Start()
    {
        initRootConnection();
        onStart();
    }

    public void initRootConnection()
    {
        gManager = GameObject.FindWithTag("GameManager").GetComponent<GameManager>();
    }

    virtual public void onStart()
    {

    }

    virtual public void onGameState(Sudoku.GameState state)
    {

    }
}