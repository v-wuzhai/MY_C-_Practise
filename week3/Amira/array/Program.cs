using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = Array.Empty<int>(); // Initialize to an empty array
        int target;

        while (true)
        {
            try
            {
                // Read input for the array
                Console.WriteLine("Enter the numbers separated by spaces:");
                string? input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    throw new ArgumentException("\nInput cannot be empty.\n");
                }

                // Try parsing the numbers and handle format exceptions
                try
                {
                    numbers = input.Split(' ').Select(int.Parse).ToArray();
                }
                catch (FormatException)
                {
                    throw new ArgumentException("\nPlease enter valid integers separated by spaces.\n");
                }

                // Read input for the target
                Console.WriteLine("Enter the target number:");
                if (!int.TryParse(Console.ReadLine(), out target))
                {
                    throw new ArgumentException("\nTarget must be a valid integer.\n");
                }

                // Call the TwoSum function
                var result = TwoSum(numbers, target);

                // Output the result
                if (result != null)
                {
                    Console.WriteLine($"index1={result[0]}, index2={result[1]}");
                }
                else
                {
                    Console.WriteLine("No solution found.");
                }

                // Exit the loop if everything is correct
                break;
            }
            catch (ArgumentException ex)
            {
                // Print error message and allow the user to try again
                Console.WriteLine($"\nError: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Catch any other unforeseen exceptions
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
        }
    }

    static int[]? TwoSum(int[] numbers, int target)
    {
        // Create a dictionary to store the number and its index
        var numToIndex = new Dictionary<int, int>();

        // Iterate through the array
        for (int i = 0; i < numbers.Length; i++)
        {
            int num = numbers[i];
            int complement = target - num;

            // Check if the complement is already in the dictionary
            if (numToIndex.TryGetValue(complement, out int index))
            {
                // Return the 1-based indices
                return new int[] { index + 1, i + 1 };
            }

            // Store the current number and its index in the dictionary
            numToIndex[num] = i;
        }

        // If no solution is found, return null
        return null;
    }
}
