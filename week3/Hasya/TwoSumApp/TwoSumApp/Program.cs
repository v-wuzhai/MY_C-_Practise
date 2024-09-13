using System;
using System.Collections.Generic;

namespace TwoSumApp
{
    class TwoSumSolver
    {
        private List<float> numbers = new List<float>();

        // Adds a number to the list
        public void AddNumber(float num)
        {
            numbers.Add(num);
        }

        // Finds two numbers that sum to the target
        public void FindTwoSum(float target)
        {
            if (numbers.Count < 2)
            {
                Console.WriteLine("Not enough numbers to find a pair.");
                return;
            }

            // Use a dictionary to store numbers and their indices
            Dictionary<float, int> numDict = new Dictionary<float, int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                float complement = target - numbers[i];

                if (numDict.ContainsKey(complement))
                {
                    Console.WriteLine($"Pair found at indices {numDict[complement] + 1} and {i + 1}.");
                    return;
                }

                // Store the current number and its index
                numDict[numbers[i]] = i;
            }

            Console.WriteLine($"No pair found for the target {target}.");
        }
    }

    class Program
    {
        static void Main()
        {
            TwoSumSolver solver = new TwoSumSolver();
            Console.WriteLine("### Two Sum Solver ###");

            // Reading input numbers from the user
            while (true)
            {
                Console.Write("Enter a number (or type 'done' to finish): ");
                string input = Console.ReadLine();

                if (input.ToLower() == "done")
                    break;

                if (float.TryParse(input, out float number))
                {
                    solver.AddNumber(number);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }

            // Reading the target number
            Console.Write("Enter the target sum: ");
            string targetInput = Console.ReadLine();
            if (float.TryParse(targetInput, out float target))
            {
                solver.FindTwoSum(target);
            }
            else
            {
                Console.WriteLine("Invalid target value.");
            }

            // Keep the console window open until the user presses Enter
            Console.WriteLine("\nPress Enter to exit...");
            Console.ReadLine();  // This keeps the console open
        }
    }
}
