using System;
using System.Collections.Generic;

namespace WordSearchApp
{
    public class WordSearchLogic2
    {
        private char[,] grid;
        private int rows;
        private int cols;

        public WordSearchLogic2(string text)
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

        public int SearchXMasPattern()
        {
            int count = 0;
            for (int i = 0; i < rows - 2; i++)
            {
                for (int j = 0; j < cols - 2; j++)
                {
                   if (grid[i, j] == 'M' && grid[i + 1, j + 1] == 'A' && grid[i + 2, j + 2] == 'S' &&
                        grid[i, j + 2] == 'M' && grid[i + 2, j] == 'S')
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        public int SearchWord()
        {
            int totalCount = SearchXMasPattern();
            return totalCount;
        }
    }
}
