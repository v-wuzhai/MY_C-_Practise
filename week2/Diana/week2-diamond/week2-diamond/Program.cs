using System;

class DiamondPattern
{
    public static void PrintDiamond(int n)
    {
        if (n <= 0 || n % 2 == 0)
        {
            Console.WriteLine("Please enter a positive odd number.");
            return;
        }

        // Print the top half including the middle line
        for (int i = 0; i < n; i += 2)
        {
            // Print leading spaces
            for (int j = 0; j < (n - i - 1) / 2; j++)
            {
                Console.Write(" ");
            }

            // Print stars
            for (int k = 0; k <= i; k++)
            {
                Console.Write("*");
            }

            // Move to the next line
            Console.WriteLine();
        }

        // Print the bottom half
        for (int i = n - 3; i >= 0; i -= 2)
        {
            // Print leading spaces
            for (int j = 0; j < (n - i - 1) / 2; j++)
            {
                Console.Write(" ");
            }

            // Print stars
            for (int k = 0; k <= i; k++)
            {
                Console.Write("*");
            }

            // Move to the next line
            Console.WriteLine();
        }
    }

    static void Main()
    {
        Console.WriteLine("Enter an odd number to generate the diamond pattern:");
        int n = int.Parse(Console.ReadLine());

        PrintDiamond(n);
    }
}
