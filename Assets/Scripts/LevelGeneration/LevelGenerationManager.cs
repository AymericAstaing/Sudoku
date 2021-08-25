using UnityEngine;
using System;

public class LevelGenerationManager : MonoBehaviour
{
    Level[] levels;
    private static int TOTAL_POSSIBLE_LEVEL = 200;
    private static int DOT = 46;
    string levelPatternsFile = "Assets/Resources/Patterns/BoardPatterns.txt";

    public Level getLevel(Sudoku.Difficulty difficulty)
    {
        switch (difficulty) {
            case Sudoku.Difficulty.SIMPLE:
                return levels[UnityEngine.Random.Range(0, 49)];
            case Sudoku.Difficulty.EASY:
                return levels[UnityEngine.Random.Range(50, 99)];
            case Sudoku.Difficulty.INTERMEDIATE:
                return levels[UnityEngine.Random.Range(100, 149)];
            case Sudoku.Difficulty.EXPERT:
                return levels[UnityEngine.Random.Range(150, 199)];
        }
        return levels[UnityEngine.Random.Range(0, 49)];
    }

    public void parsePatternFile()
    {
        print("LevelGenerationManager: parsePatternFile");
        levels = new Level[TOTAL_POSSIBLE_LEVEL];
        string[] lines = System.IO.File.ReadAllLines(levelPatternsFile);
        for (int i = 0; i < TOTAL_POSSIBLE_LEVEL; ++i) {
            Level l = new Level(i, getCurrentLevelDifficulty(i), getExctractedBoard(lines[i]));
            levels[i] = l;
        }
    }

    private Sudoku.Difficulty getCurrentLevelDifficulty(int id)
    {
        if (id < 50)
            return Sudoku.Difficulty.SIMPLE;
        if (id < 100)
            return Sudoku.Difficulty.EASY;
        if (id < 150)
            return Sudoku.Difficulty.INTERMEDIATE;
        return Sudoku.Difficulty.EXPERT;
    }

    private int[] getExctractedBoard(string currentLine)
    {
        int[] board = new int[Sudoku.TOTAL_TILE_NBR_9x9];

        for (int i = 0; i < currentLine.Length - 1; ++i) {
            if (currentLine[i] == DOT) {
                board[i] = 0;
                continue;
            }
            board[i] = (int) char.GetNumericValue(currentLine[i]);
        }
        return board;
    }
}