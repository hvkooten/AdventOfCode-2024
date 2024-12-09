using System;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string file1 = "InputFile1.txt";
        string file2 = "InputFile2.txt";

        int result1 = ProcessFile(file1);
        int result2 = ProcessFile(file2);

        Console.WriteLine($"Result for {file1}: {result1}");
        Console.WriteLine($"Result for {file2}: {result2}");
    }

    static int ProcessFile(string filePath)
    {
        string content = File.ReadAllText(filePath);
        var matches = Regex.Matches(content, @"mul\((\d+),(\d+)\)");

        int sum = 0;
        foreach (Match match in matches)
        {
            int x = int.Parse(match.Groups[1].Value);
            int y = int.Parse(match.Groups[2].Value);
            sum += x * y;
        }

        return sum;
    }
}
