using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string file1 = "TextFile1.txt";
        string file2 = "TextFile2.txt";

        int safeReports1 = CalculateSafeReports(file1);
        int safeReports2 = CalculateSafeReports(file2);

        Console.WriteLine($"Number of safe reports in {file1}: {safeReports1}");
        Console.WriteLine($"Number of safe reports in {file2}: {safeReports2}");
    }

    static int CalculateSafeReports(string filePath)
    {
        var lines = File.ReadAllLines(filePath);
        int safeReports = 0;

        foreach (var line in lines)
        {
            var levels = line.Split(' ').Select(int.Parse).ToArray();
            if (IsSafeReport(levels))
            {
                safeReports++;
            }
        }

        return safeReports;
    }

    static bool IsSafeReport(int[] levels)
    {
        bool increasing = true;
        bool decreasing = true;

        for (int i = 1; i < levels.Length; i++)
        {
            int diff = levels[i] - levels[i - 1];
            if (Math.Abs(diff) < 1 || Math.Abs(diff) > 3)
            {
                return false;
            }
            if (levels[i] > levels[i - 1])
            {
                decreasing = false;
            }
            if (levels[i] < levels[i - 1])
            {
                increasing = false;
            }
        }

        return increasing || decreasing;
    }
}
