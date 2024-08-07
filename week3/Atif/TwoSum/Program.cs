using System;
using System.Collections.Generic;

class Program
{
    public static List<Tuple<int, int>> TwoSum(List<int> numbers, int target)
    {
        var result = new List<Tuple<int, int>>();

        for (int i = 0; i < numbers.Count; i++)
        {
            for (int j = i + 1; j < numbers.Count; j++)
            {
                if (numbers[i] + numbers[j] == target)
                {
                    result.Add(new Tuple<int, int>(i + 1, j + 1));
                }
            }
        }

        return result;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of elements in the array:");
        int n = int.Parse(Console.ReadLine());

        List<int> numbers = new List<int>();
        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < n; i++)
        {
            numbers.Add(int.Parse(Console.ReadLine()));
        }

        Console.WriteLine("Enter the target number:");
        int target = int.Parse(Console.ReadLine());

        List<Tuple<int, int>> result = TwoSum(numbers, target);

        if (result.Count > 0)
        {
            foreach (var pair in result)
            {
                Console.WriteLine("Index 1: {0}, Index 2: {1}", pair.Item1, pair.Item2);
            }
        }
        else
        {
            Console.WriteLine("There is no solution for the target number.");
        }
    }
}
