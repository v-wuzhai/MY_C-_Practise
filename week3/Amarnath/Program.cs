using System;
using System.Collections.Generic;

class Program
{
    public static List<List<int>> FindAllTwoSums(List<int> numbers, int target)
    {
       
        var indexedNumbers = new List<(int Value, int Index)>();
        for (int i = 0; i < numbers.Count; i++)
        {
            indexedNumbers.Add((numbers[i], i + 1));
        }

     
        indexedNumbers.Sort((a, b) => a.Value.CompareTo(b.Value));

        var results = new List<List<int>>();
        int left = 0, right = indexedNumbers.Count - 1;

        while (left < right)
        {
            int currentSum = indexedNumbers[left].Value + indexedNumbers[right].Value;

            if (currentSum == target)
            {
                results.Add(new List<int> { indexedNumbers[left].Index, indexedNumbers[right].Index });
            
                left++;
                right--;
            }
            else if (currentSum < target)
            {
                left++;
            }
            else
            {
                right--;
            }
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
