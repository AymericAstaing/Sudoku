using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuUiScript : GameManagedObject
{
    private Canvas canvas;

    public override void onStart()
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

    }

    public override void onGameState(Sudoku.GameState state)
    {
        switch (state) {
            case Sudoku.GameState.IN_GAME:
                canvas.enabled = false;
                break;
            case Sudoku.GameState.IN_MENU:
                canvas.enabled = true;
                break;
        }
    }
}
