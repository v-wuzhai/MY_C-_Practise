using System;
using System.Collections.Generic;

class Program
{
    public static Tuple<int, int> FindTwoSum(List<int> numbers, int target)
    {
        var numberIndices = new Dictionary<int, int>();

        for (int i = 0; i < numbers.Count; i++)
        {
            int complement = target - numbers[i];

            if (numberIndices.ContainsKey(complement))
            {
                return Tuple.Create(numberIndices[complement] + 1, i + 1);
            }

            numberIndices[numbers[i]] = i;
        }

        return null;
    }

    static void Main()
    {
        Console.WriteLine("Enter quantity of numbers:");
        int count = int.Parse(Console.ReadLine());

        var numbers = new List<int>();
        Console.WriteLine("Enter the numbers:");
        for (int i = 0; i < count; i++)
        {
            numbers.Add(int.Parse(Console.ReadLine()));
        }

        Console.WriteLine("Enter the target number:");
        int target = int.Parse(Console.ReadLine());

        var result = FindTwoSum(numbers, target);

        if (result != null)
        {
            Console.WriteLine($"Index 1: {result.Item1}, Index 2: {result.Item2}");
        }
        else
        {
            Console.WriteLine("Cannot return solution");
        }
    }
}
