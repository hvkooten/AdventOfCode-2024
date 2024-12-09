using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string file1 = "file1.txt";
        string file2 = "file2.txt";
        string file3 = "file3.txt";
        string file4 = "file4.txt";

        int sumOfMiddlePageNumbers1 = Calculate1(file1, file2);
        int sumOfMiddlePageNumbers2 = Calculate1(file3, file4);

        Console.WriteLine($"Sum of middle page numbers for first calculation: {sumOfMiddlePageNumbers1}");
        Console.WriteLine($"Sum of middle page numbers for second calculation: {sumOfMiddlePageNumbers2}");

        sumOfMiddlePageNumbers1 = Calculate2(file1, file2);
        sumOfMiddlePageNumbers2 = Calculate2(file3, file4);

        Console.WriteLine($"Sum of middle page numbers for first calculation: {sumOfMiddlePageNumbers1}");
        Console.WriteLine($"Sum of middle page numbers for second calculation: {sumOfMiddlePageNumbers2}");
    }

    static int Calculate1(string file1, string file2)
    {
        var rules = File.ReadAllLines(file1);
        var updates = File.ReadAllLines(file2);

        var pageOrderRules = ParsePageOrderRules(rules);
        var updatesList = ParseUpdates(updates);

        var validUpdates = updatesList.Where(update => IsValidUpdate(update, pageOrderRules)).ToList();
        var middlePageNumbers = validUpdates.Select(update => update[update.Count / 2]).ToList();
        var sumOfMiddlePageNumbers = middlePageNumbers.Sum();

        return sumOfMiddlePageNumbers;
    }

    static int Calculate2(string file1, string file2)
    {
        var rules = File.ReadAllLines(file1);
        var updates = File.ReadAllLines(file2);

        var pageOrderRules = ParsePageOrderRules(rules);
        var updatesList = ParseUpdates(updates);

        var nonValidUpdates = updatesList.Where(update => !IsValidUpdate(update, pageOrderRules)).ToList();
        var reorderedUpdates = nonValidUpdates.Select(update => ReorderUpdate(update, pageOrderRules)).ToList();
        var validUpdates = reorderedUpdates.Where(update => IsValidUpdate(update, pageOrderRules)).ToList();
        var middlePageNumbers = validUpdates.Select(update => update[update.Count / 2]).ToList();
        var sumOfMiddlePageNumbers = middlePageNumbers.Sum();

        return sumOfMiddlePageNumbers;
    }

    static Dictionary<int, List<int>> ParsePageOrderRules(string[] rules)
    {
        var pageOrderRules = new Dictionary<int, List<int>>();

        foreach (var rule in rules)
        {
            var parts = rule.Split('|');
            int before = int.Parse(parts[0]);
            int after = int.Parse(parts[1]);

            if (!pageOrderRules.ContainsKey(before))
            {
                pageOrderRules[before] = new List<int>();
            }

            pageOrderRules[before].Add(after);
        }

        return pageOrderRules;
    }

    static List<List<int>> ParseUpdates(string[] updates)
    {
        var updatesList = new List<List<int>>();

        foreach (var update in updates)
        {
            var pages = update.Split(',').Select(int.Parse).ToList();
            updatesList.Add(pages);
        }

        return updatesList;
    }

    static bool IsValidUpdate(List<int> update, Dictionary<int, List<int>> pageOrderRules)
    {
        for (int i = 0; i < update.Count; i++)
        {
            for (int j = i + 1; j < update.Count; j++)
            {
                int page1 = update[i];
                int page2 = update[j];

                if (!pageOrderRules.ContainsKey(page1) || !pageOrderRules[page1].Contains(page2))
                {
                    return false;
                }
            }
        }

        return true;
    }

    static List<int> ReorderUpdate(List<int> update, Dictionary<int, List<int>> pageOrderRules)
    {
        var reorderedUpdate = new List<int>(update);
        reorderedUpdate.Sort((page1, page2) =>
        {
            if (pageOrderRules.ContainsKey(page1) && pageOrderRules[page1].Contains(page2))
            {
                return -1;
            }
            else if (pageOrderRules.ContainsKey(page2) && pageOrderRules[page2].Contains(page1))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        });

        return reorderedUpdate;
    }
}
