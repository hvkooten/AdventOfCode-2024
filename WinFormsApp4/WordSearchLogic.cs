using System;
using System.Collections.Generic;

namespace WordSearchApp
{
    public class WordSearchLogic
    {
        private char[,] grid;
        private int rows;
        private int cols;

        public WordSearchLogic(string text)
        {
            ConvertTextToGrid(text);
        }

        private void ConvertTextToGrid(string text)
        {
            string[] lines = text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            rows = lines.Length;
            cols = lines[0].Length;
            grid = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    grid[i, j] = lines[i][j];
                }
            }
        }

        public (int verticalCount, int horizontalCount, int diagonalCount, int totalCount) SearchWord(string word)
        {
            int verticalCount = SearchVertical(word);
            int horizontalCount = SearchHorizontal(word);
            int diagonalCount = SearchDiagonal(word);
            int totalCount = verticalCount + horizontalCount + diagonalCount;
            return (verticalCount, horizontalCount, diagonalCount, totalCount);
        }

        private int SearchHorizontal(string word)
        {
            int count = 0;
            for (int i = 0; i < rows; i++)
            {
                string row = new string(GetRow(i));
                count += CountOccurrences(row, word);
                count += CountOccurrences(ReverseString(row), word);
            }
            return count;
        }

        private int SearchVertical(string word)
        {
            int count = 0;
            for (int j = 0; j < cols; j++)
            {
                string col = new string(GetColumn(j));
                count += CountOccurrences(col, word);
                count += CountOccurrences(ReverseString(col), word);
            }
            return count;
        }

        private int SearchDiagonal(string word)
        {
            int count = 0;
            List<string> diagonals = GetDiagonals();
            foreach (string diagonal in diagonals)
            {
                count += CountOccurrences(diagonal, word);
                count += CountOccurrences(ReverseString(diagonal), word);
            }
            return count;
        }

        private char[] GetRow(int rowIndex)
        {
            char[] row = new char[cols];
            for (int j = 0; j < cols; j++)
            {
                row[j] = grid[rowIndex, j];
            }
            return row;
        }

        private char[] GetColumn(int colIndex)
        {
            char[] col = new char[rows];
            for (int i = 0; i < rows; i++)
            {
                col[i] = grid[i, colIndex];
            }
            return col;
        }

        private List<string> GetDiagonals()
        {
            List<string> diagonals = new List<string>();

            for (int i = 0; i < rows; i++)
            {
                diagonals.Add(GetDiagonal(i, 0, 1, 1));
            }

            for (int i = 0; i < rows; i++)
            {
                diagonals.Add(GetDiagonal(i, grid.GetLength(0) - 1, 1, -1));
            }

            for (int j = 1; j < cols; j++)
            {
                diagonals.Add(GetDiagonal(0, j, 1, 1));
            }
            for (int j = 1; j < cols; j++)
            {
                diagonals.Add(GetDiagonal(0, j, 1, -1));
            }
            diagonals.RemoveAt(diagonals.Count - 1);
            return diagonals;
        }

        private string GetDiagonal(int startX, int startY, int dx, int dy)
        {
            List<char> diagonal = new List<char>();
            int x = startX;
            int y = startY;

            while (x >= 0 && x < rows && y >= 0 && y < cols)
            {
                diagonal.Add(grid[x, y]);
                x += dx;
                y += dy;
            }

            return new string(diagonal.ToArray());
        }

        private int CountOccurrences(string text, string word)
        {
            int count = 0;
            int index = text.IndexOf(word);
            while (index != -1)
            {
                count++;
                index = text.IndexOf(word, index + 1);
            }
            return count;
        }

        private string ReverseString(string text)
        {
            char[] charArray = text.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
