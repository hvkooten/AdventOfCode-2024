using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string file1 = "TextFile1.txt";
        string file2 = "TextFile2.txt";

        int totalDistance1 = CalculateTotalDistance(file1);
        int totalDistance2 = CalculateTotalDistance(file2);

        Console.WriteLine($"Total distance for {file1}: {totalDistance1}");
        Console.WriteLine($"Total distance for {file2}: {totalDistance2}");

        int similarityScore1 = CalculateSimilarityScore(file1);
        int similarityScore2 = CalculateSimilarityScore(file2);

        Console.WriteLine($"Similarity score for {file1}: {similarityScore1}");
        Console.WriteLine($"Similarity score for {file2}: {similarityScore2}");
    }

    static int CalculateTotalDistance(string filePath)
    {
        var lines = File.ReadAllLines(filePath);
        var leftNumbers = lines.Select(line => int.Parse(line.Split("   ")[0])).ToList();
        var rightNumbers = lines.Select(line => int.Parse(line.Split("   ")[1])).ToList();

        leftNumbers.Sort();
        rightNumbers.Sort();

        int totalDistance = 0;
        for (int i = 0; i < leftNumbers.Count; i++)
        {
            totalDistance += Math.Abs(leftNumbers[i] - rightNumbers[i]);
        }

        return totalDistance;
    }

    static int CalculateSimilarityScore(string filePath)
    {
        var lines = File.ReadAllLines(filePath);
        var leftNumbers = lines.Select(line => int.Parse(line.Split("   ")[0])).ToList();
        var rightNumbers = lines.Select(line => int.Parse(line.Split("   ")[1])).ToList();

        int similarityScore = 0;
        foreach (var number in leftNumbers)
        {
            int count = rightNumbers.Count(n => n == number);
            similarityScore += number * count;
        }

        return similarityScore;
    }
}
