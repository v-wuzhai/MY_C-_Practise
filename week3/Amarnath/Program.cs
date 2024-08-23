using System;
using System.Collections.Generic;

class Program
{
    public static List<List<int>> FindAllTwoSums(List<int> numbers, int target)
    {
        var results = new List<List<int>>();
        var seenNumbers = new Dictionary<int, List<int>>();
        
        for (int i = 0; i < numbers.Count; i++)
        {
            int complement = target - numbers[i];
            
            if (seenNumbers.ContainsKey(complement))
            {
                foreach (var index in seenNumbers[complement])
                {
                    results.Add(new List<int> { index, i + 1 });
                }
            }
            
            if (!seenNumbers.ContainsKey(numbers[i]))
            {
                seenNumbers[numbers[i]] = new List<int>();
            }
            seenNumbers[numbers[i]].Add(i + 1);
        }
        
        return results;
    }

    static void Main()
    {
        Console.WriteLine("Enter the number of elements:");
        int count = int.Parse(Console.ReadLine());

        var numbers = new List<int>();
        Console.WriteLine("Enter the elements:");
        for (int i = 0; i < count; i++)
        {
            numbers.Add(int.Parse(Console.ReadLine()));
        }

        Console.WriteLine("Enter the target value:");
        int target = int.Parse(Console.ReadLine());

        var results = FindAllTwoSums(numbers, target);

        if (results.Count > 0)
        {
            foreach (var pair in results)
            {
                Console.WriteLine($"Indices: {pair[0]}, {pair[1]}");
            }
        }
        else
        {
            Console.WriteLine("No pairs found that add up to the target.");
        }
    }
}
