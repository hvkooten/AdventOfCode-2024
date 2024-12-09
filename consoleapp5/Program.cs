using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string input = @"
47|53
97|13
97|61
97|47
75|29
61|13
75|53
29|13
97|29
53|29
61|53
97|53
61|29
47|13
75|47
97|75
47|61
75|61
47|29
75|13
53|13

75,47,61,53,29
97,61,53,29,13
75,29,13
75,97,47,61,53
61,13,29
97,13,75,29,47";

        var sections = input.Split(new[] { "\n\n" }, StringSplitOptions.None);
        var rules = sections[0].Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
        var updates = sections[1].Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

        var pageOrderRules = ParsePageOrderRules(rules);
        var updatesList = ParseUpdates(updates);

        var validUpdates = updatesList.Where(update => IsValidUpdate(update, pageOrderRules)).ToList();
        var middlePageNumbers = validUpdates.Select(update => update[update.Count / 2]).ToList();
        var sumOfMiddlePageNumbers = middlePageNumbers.Sum();

        Console.WriteLine($"Sum of middle page numbers: {sumOfMiddlePageNumbers}");
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

                if (pageOrderRules.ContainsKey(page1) && pageOrderRules[page1].Contains(page2))
                {
                    return false;
                }
            }
        }

        return true;
    }
}
