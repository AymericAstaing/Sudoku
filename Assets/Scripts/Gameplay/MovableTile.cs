using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovableTile : GameManagedObject
{
    private Image tileImage;
    private bool isMoving = false;

    public override void onStart()
    {
        isMoving = true;
    }

    void Update()
    {
        manageMovement();
        if (isMoving)
            transform.position = Input.mousePosition;
    }

    public void init(int tileValue)
    {
        tileImage = GetComponent<Image>();
        tileImage.sprite = Resources.Load<Sprite>("Gameplay/Tiles/tile_" + (tileValue));
    }

    private void manageMovement()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (!isMoving)
                    isMoving = !isMoving;
            print ("START MOVE");
        }

        if (Input.GetMouseButtonUp(0))
        {
            if (isMoving)
                    isMoving = !isMoving;
            print ("STOP MOVE");
        }
    }
}