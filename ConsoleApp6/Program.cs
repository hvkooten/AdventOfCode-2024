using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        string[] files = { "file1.txt", "file2.txt" };

        foreach (var file in files)
        {
            var map = LoadMap(file);
            var distinctPositions = SimulateGuardPatrol(map);
            Console.WriteLine($"Number of distinct positions visited for {file}: {distinctPositions}");
        }
    }

    static char[,] LoadMap(string filePath)
    {
        var lines = File.ReadAllLines(filePath);
        int rows = lines.Length;
        int cols = lines[0].Length;
        var map = new char[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                map[i, j] = lines[i][j];
            }
        }

        return map;
    }

    static int SimulateGuardPatrol(char[,] map)
    {
        int rows = map.GetLength(0);
        int cols = map.GetLength(1);
        int guardRow = -1, guardCol = -1;
        char guardDirection = '^';

        // Find the initial position of the guard
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (map[i, j] == '^')
                {
                    guardRow = i;
                    guardCol = j;
                    break;
                }
            }
            if (guardRow != -1) break;
        }

        var visitedPositions = new HashSet<(int, int)>();
        visitedPositions.Add((guardRow, guardCol));

        while (true)
        {
            int nextRow = guardRow, nextCol = guardCol;

            switch (guardDirection)
            {
                case '^': nextRow--; break;
                case '>': nextCol++; break;
                case 'v': nextRow++; break;
                case '<': nextCol--; break;
            }

            if (nextRow < 0 || nextRow >= rows || nextCol < 0 || nextCol >= cols || map[nextRow, nextCol] == '#')
            {
                guardDirection = TurnRight(guardDirection);
            }
            else
            {
                guardRow = nextRow;
                guardCol = nextCol;
                visitedPositions.Add((guardRow, guardCol));
                map[guardRow, guardCol] = GetDirectionChar(guardDirection);
            }

            if (guardRow < 0 || guardRow >= rows || guardCol < 0 || guardCol >= cols)
            {
                break;
            }
        }

        return visitedPositions.Count;
    }

    static char TurnRight(char direction)
    {
        switch (direction)
        {
            case '^': return '>';
            case '>': return 'v';
            case 'v': return '<';
            case '<': return '^';
            default: throw new ArgumentException("Invalid direction");
        }
    }

    static char GetDirectionChar(char direction)
    {
        switch (direction)
        {
            case '^': return 'U';
            case '>': return 'R';
            case 'v': return 'D';
            case '<': return 'L';
            default: throw new ArgumentException("Invalid direction");
        }
    }
}
