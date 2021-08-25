using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuUiScript : GameManagedObject
{
    private Canvas canvas;

    void Start()
    {
        getLocalComponents();
        setInitialComponentsState();
    }

    void Update()
    {

    }

    private void getLocalComponents()
    {
        canvas = GetComponent<Canvas>();
    }

    private void setInitialComponentsState()
    {
        canvas.enabled = false;
    }

    public override void onGameState(Sudoku.GameState state)
    {
        switch (state) {
            case Sudoku.GameState.IN_PAUSE_MENU:
                canvas.enabled = true;
                break;
            case Sudoku.GameState.IN_RESUME:
                canvas.enabled = false;
                break;
            case Sudoku.GameState.IN_MENU:
                canvas.enabled = false;
                break;
            case Sudoku.GameState.IN_RESTART:
                canvas.enabled = false;
                break;
        }
    }
}
