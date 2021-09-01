using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIEventManager : GameManagedObject
{
    public override void onStart()
    {
    }

    void Update()
    {

    }

    public void onStartPressed()
    {
        gManager.startGame();
    }
}
