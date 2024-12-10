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

        var totalCalibrationResult1 = CalculateTotalCalibrationResult(file1);
        var totalCalibrationResult2 = CalculateTotalCalibrationResult(file2);

        Console.WriteLine($"Total calibration result for {file1}: {totalCalibrationResult1}");
        Console.WriteLine($"Total calibration result for {file2}: {totalCalibrationResult2}");
    }

    static long CalculateTotalCalibrationResult(string filePath)
    {
        var lines = File.ReadAllLines(filePath);
        long totalCalibrationResult = 0;

        foreach (var line in lines)
        {
            var parts = line.Split(':');
            long testValue = long.Parse(parts[0]);
            var numbers = parts[1].Trim().Split(' ').Select(long.Parse).ToArray();

            if (IsValidEquation(testValue, numbers))
            {
                totalCalibrationResult += testValue;
            }
        }

        return totalCalibrationResult;
    }

    static bool IsValidEquation(long testValue, long[] numbers)
    {
        return CheckCombinations(testValue, numbers, 0, numbers[0]);
    }

    static bool CheckCombinations(long testValue, long[] numbers, long index, long currentResult)
    {
        if (index == numbers.Length - 1)
        {
            if (currentResult == testValue)
                return true;
            else
                return false;
        }

        long nextIndex = index + 1;
        return CheckCombinations(testValue, numbers, nextIndex, currentResult + numbers[nextIndex]) ||
               CheckCombinations(testValue, numbers, nextIndex, currentResult * numbers[nextIndex]) ||
               CheckCombinations(testValue, numbers, nextIndex, ConcatenateNumbers(currentResult, numbers[nextIndex]));
    }

    static long ConcatenateNumbers(long num1, long num2)
    {
        return long.Parse($"{num1}{num2}");
    }
}
