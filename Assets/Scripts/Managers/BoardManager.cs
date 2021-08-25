using UnityEngine;
using UnityEngine.UI;

public class BoardManager : MonoBehaviour
{
    public GameObject[] boardTiles;
    private Image[] boardTilesImage;
    private GameObject[] selectorButtons;
    public GameObject movingTilePrefab;
    private static int EMPTY_CELL = 0;
    private float verticalPosTileSelectionBoard = 0;
    private int[] currentLevelBoard;
    private Sprite[] tilesTexture;
    private bool tileInMove = false;

    public void Start()
    {
        init();
        getImagesComponent();
        loadResources();
    }

    private void loadResources()
    {
        tilesTexture = new Sprite[Sudoku.SELECTABLE_TILE_NBR_9x9];
        for (int i = 0; i < Sudoku.SELECTABLE_TILE_NBR_9x9; ++i) {
            tilesTexture[i] = Resources.Load<Sprite>("Gameplay/Tiles/tile_" + i);
            if (!tilesTexture[i])
                print("Error loading texture: \"" + "Gameplay/Tiles/tile_" + i + "\"");
        }
        print("BoardManager: resources initialised.");
    }

    private void getImagesComponent()
    {
        boardTilesImage = new Image[Sudoku.TOTAL_TILE_NBR_9x9];
        for (int i = 0; i < boardTiles.Length; ++i)
            boardTilesImage[i] = boardTiles[i].GetComponent<Image>();
    }

    public void init()
    {
        currentLevelBoard = new int[Sudoku.TOTAL_TILE_NBR_9x9];
        selectorButtons = new GameObject[Sudoku.SELECTABLE_TILE_NBR_9x9];
        for (int i = 0; i < Sudoku.SELECTABLE_TILE_NBR_9x9; ++i)
            selectorButtons[i] = this.gameObject.transform.GetChild(2).GetChild(i).gameObject;
        verticalPosTileSelectionBoard = this.gameObject.transform.GetChild(2).gameObject.transform.localPosition.y;
    }

    public void setUpLevelBoard(Level level)
    {
        int[] board = level.getBoard();
        for (int i = 0; i < board.Length; ++i) {
            currentLevelBoard[i] = board[i];
            if (board[i] == EMPTY_CELL)
                continue;
            boardTilesImage[i].sprite = tilesTexture[board[i] - 1];
        }
        print("BoardManager: board loaded.");
    }

    public void OnSelectorTileClicked(int tileValue)
    {
        print("selector button " + tileValue + " touched.");
        if (tileInMove)
            return;
        Vector3 movableTilePos = new Vector3(selectorButtons[tileValue].transform.localPosition.x, verticalPosTileSelectionBoard, 0);
        GameObject movingTile = Instantiate(movingTilePrefab, movableTilePos, Quaternion.identity);
        movingTile.transform.SetParent(transform, false);
        MovableTile movingTileScript = movingTile.GetComponent<MovableTile>();
        movingTileScript.init(tileValue);
    }

    public void OnSelectorTileReleased()
    {

    }
}