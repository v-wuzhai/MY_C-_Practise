using System;
using System.Collections.Generic;

public class Solution
{
    public List<int[]> TwoSumAll(int[] numbers, int target)
    {
        Dictionary<int, int> numDict = new Dictionary<int, int>();
        List<int[]> result = new List<int[]>();

        for (int i = 0; i < numbers.Length; i++)
        {
            int complement = target - numbers[i];
            if (numDict.ContainsKey(complement))
            {
                result.Add(new int[] { numDict[complement] + 1, i + 1 }); // Return 1-based indices
            }
            if (!numDict.ContainsKey(numbers[i]))
            {
                numDict[numbers[i]] = i;
            }
        }

        if (result.Count == 0)
        {
            throw new Exception("No two sum solution found");
        }

        return result;
    }
}

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter the number of elements in the array:");
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];
            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter the target number:");
            int target = int.Parse(Console.ReadLine());

            Solution solution = new Solution();
            List<int[]> results = solution.TwoSumAll(numbers, target);

            Console.WriteLine("Pairs of indices that sum up to the target:");
            foreach (var pair in results)
            {
                Console.WriteLine($"index1={pair[0]}, index2={pair[1]}");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter valid integers.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}
