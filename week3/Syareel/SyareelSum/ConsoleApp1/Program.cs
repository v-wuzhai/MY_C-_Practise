using System;
using System.Collections.Generic;

class Program
{
    public static List<Tuple<int, int>> FindTwoSum(List<int> numbers, int target)
    {
        var numberIndices = new Dictionary<int, int>();
        var results = new List<Tuple<int, int>>();

        for (int i = 0; i < numbers.Count; i++)
        {
            int complement = target - numbers[i];

            if (numberIndices.ContainsKey(complement))
            {
                results.Add(Tuple.Create(numberIndices[complement] + 1, i + 1));
            }

            numberIndices[numbers[i]] = i;
        }

        return results;
    }

    static void Main()
    {
        Console.WriteLine("Enter quantity of numbers:");
        if (!int.TryParse(Console.ReadLine(), out int count) || count <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
            return;
        }

        var numbers = new List<int>();
        Console.WriteLine("Enter the numbers:");
        for (int i = 0; i < count; i++)
        {
            if (!int.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine("Invalid input. Please enter an integer.");
                return;
            }
            numbers.Add(number);
        }

        Console.WriteLine("Enter the target number:");
        if (!int.TryParse(Console.ReadLine(), out int target))
        {
            Console.WriteLine("Invalid input. Please enter an integer.");
            return;
        }

        var results = FindTwoSum(numbers, target);

        if (results.Count > 0)
        {
            foreach (var result in results)
            {
                Console.WriteLine($"Index 1: {result.Item1}, Index 2: {result.Item2}");
            }
        }
        else
        {
            Console.WriteLine("Cannot return solution");
        }
    }
}
