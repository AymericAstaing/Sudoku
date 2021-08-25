    public class Level
{
    private int _id = 0;
    private Sudoku.Difficulty _difficulty;
    private int[] _board = new int[Sudoku.TOTAL_TILE_NBR_9x9];

    public Level(int id, Sudoku.Difficulty difficulty, int[] board)
    {
        _id = id;
        _difficulty = difficulty;
        _board = board;
    }

    public Level(Level level)
    {
        _id = level.getId();
        _difficulty = level.getDifficulty();
        _board = level.getBoard();
    }

    public int getId() { return _id; }

    public Sudoku.Difficulty getDifficulty() { return _difficulty; }

    public int[] getBoard() { return _board; }
};