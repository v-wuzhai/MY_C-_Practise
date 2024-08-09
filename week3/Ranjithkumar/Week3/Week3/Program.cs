using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("Enter the numbers separated by spaces: ");
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        
        Console.Write("Enter the target value: ");
        int target = int.Parse(Console.ReadLine());

        
        int[] result = TwoSum(numbers, target);

        
        if (result.Length == 2)
        {
            Console.WriteLine($"index1={result[0]}, index2={result[1]}");
        }
        else
        {
            Console.WriteLine("No solution found.");
        }
    }

    static int[] TwoSum(int[] numbers, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < numbers.Length; i++)
        {
            int complement = target - numbers[i];

            if (map.ContainsKey(complement))
            {
                return new int[] { map[complement] + 1, i + 1 }; 
            }

            if (!map.ContainsKey(numbers[i]))
            {
                map[numbers[i]] = i;
            }
        }

        return new int[0]; 
    }
}
