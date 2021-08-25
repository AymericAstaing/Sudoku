using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameViewUiScript : GameManagedObject
{
    private Canvas canvas;

    public override void onStart()
    {
        getLocalComponents();
        setInitialComponentsState();
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
            case Sudoku.GameState.IN_GAME:
                canvas.enabled = true;
                break;
            case Sudoku.GameState.IN_MENU:
                canvas.enabled = false;
                break;
        }
    }
}
