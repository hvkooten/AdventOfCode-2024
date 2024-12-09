using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string file1 = "ConsoleApp1/TextFile1.txt";
        string file2 = "ConsoleApp1/TextFile2.txt";

        int totalDistance1 = CalculateTotalDistance(file1);
        int totalDistance2 = CalculateTotalDistance(file2);

        Console.WriteLine($"Total distance for {file1}: {totalDistance1}");
        Console.WriteLine($"Total distance for {file2}: {totalDistance2}");
    }

    static int CalculateTotalDistance(string filePath)
    {
        var lines = File.ReadAllLines(filePath);
        var leftNumbers = lines.Select(line => int.Parse(line.Split()[0])).ToList();
        var rightNumbers = lines.Select(line => int.Parse(line.Split()[1])).ToList();

        leftNumbers.Sort();
        rightNumbers.Sort();

        int totalDistance = 0;
        for (int i = 0; i < leftNumbers.Count; i++)
        {
            totalDistance += Math.Abs(leftNumbers[i] - rightNumbers[i]);
        }

        return totalDistance;
    }
}
