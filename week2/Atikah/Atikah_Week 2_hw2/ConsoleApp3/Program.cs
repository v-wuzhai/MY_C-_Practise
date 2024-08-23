using System;

namespace DiamondPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                // Round to the nearest odd number
                if (n % 2 == 0) n++;  // Make even number odd

                // Print the diamond pattern
                PrintDiamond(n);
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }

        static void PrintDiamond(int n)
        {
            int mid = n / 2;

            for (int i = 0; i < n; i++)
            {
                int stars = i <= mid ? 2 * i + 1 : 2 * (n - i - 1) + 1;
                int spaces = (n - stars) / 2;

                Console.WriteLine(new string(' ', spaces) + new string('*', stars));
            }
        }
    }
}
