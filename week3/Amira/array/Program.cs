using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = new List<int>();
        int target;

        while (true)
        {
            try
            {
                int i = 1;
                while (true)
                {
                    Console.WriteLine("\nIf want to proceed please Enter Number. If you are done Enter 'done' to End");
                    Console.WriteLine($"Enter the {i}th number :");
                    string? input = Console.ReadLine();

                    if (input?.Trim().Equals("done", StringComparison.OrdinalIgnoreCase) == true)
                    {
                        break; 
                    }

                    if (int.TryParse(input, out int number))
                    {
                        numbers.Add(number); 
                        i++;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid integer.");
                    }
                }

                if (!numbers.Any())
                {
                    Console.WriteLine("No numbers were entered. Please try again.");
                    numbers.Clear(); 
                    continue;
                }

                Console.WriteLine("\nEnter the target number:");
                if (!int.TryParse(Console.ReadLine(), out target))
                {
                    Console.WriteLine("Target must be a valid integer. Please try again.");
                    numbers.Clear(); 
                    continue;
                }

                var results = TwoSum(numbers.ToArray(), target);

                if (results.Any())
                {
                    foreach (var result in results)
                    {
                        Console.WriteLine($"First Index = {result[0]}, Second Index = {result[1]}");
                    }
                }
                else
                {
                    Console.WriteLine("No solution found.");
                }

                break;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }

    static List<int[]> TwoSum(int[] numbers, int target)
    {
        var numToIndex = new Dictionary<int, int>();
        var results = new List<int[]>();

        for (int i = 0; i < numbers.Length; i++)
        {
            int num = numbers[i];
            int complement = target - num;

            if (numToIndex.TryGetValue(complement, out int index))
            {
                results.Add(new int[] { index + 1, i + 1 });
            }
            numToIndex[num] = i;
        }

        return results;
    }
}
