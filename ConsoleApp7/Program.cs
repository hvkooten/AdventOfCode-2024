using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string file1 = "TextFile1.txt";
        string file2 = "TextFile2.txt";

        int totalCalibrationResult1 = CalculateTotalCalibrationResult(file1);
        int totalCalibrationResult2 = CalculateTotalCalibrationResult(file2);

        Console.WriteLine($"Total calibration result for {file1}: {totalCalibrationResult1}");
        Console.WriteLine($"Total calibration result for {file2}: {totalCalibrationResult2}");
    }

    static int CalculateTotalCalibrationResult(string filePath)
    {
        var lines = File.ReadAllLines(filePath);
        int totalCalibrationResult = 0;

        foreach (var line in lines)
        {
            var parts = line.Split(':');
            int testValue = int.Parse(parts[0]);
            var numbers = parts[1].Trim().Split(' ').Select(int.Parse).ToArray();

            if (IsValidEquation(testValue, numbers))
            {
                totalCalibrationResult += testValue;
            }
        }

        return totalCalibrationResult;
    }

    static bool IsValidEquation(int testValue, int[] numbers)
    {
        return CheckCombinations(testValue, numbers, 0, numbers[0]);
    }

    static bool CheckCombinations(int testValue, int[] numbers, int index, int currentResult)
    {
        if (index == numbers.Length - 1)
        {
            return currentResult == testValue;
        }

        int nextIndex = index + 1;
        return CheckCombinations(testValue, numbers, nextIndex, currentResult + numbers[nextIndex]) ||
               CheckCombinations(testValue, numbers, nextIndex, currentResult * numbers[nextIndex]);
    }
}
