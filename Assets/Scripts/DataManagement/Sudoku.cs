public static class Sudoku
{
    public static int TOTAL_TILE_NBR_9x9 = 81;
    public static int SELECTABLE_TILE_NBR_9x9 = 9;

    public enum GameState
    {
        IN_MENU,
        IN_GAME,
        IN_PAUSE_MENU,
        IN_RESUME,
        IN_FINISH_MENU,
        IN_RESTART,
        IN_MOVABLE_TILE_RELEASE
    }

    public enum Difficulty
    {
        SIMPLE,
        EASY,
        INTERMEDIATE,
        EXPERT
    }
}
