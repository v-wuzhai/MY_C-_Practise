using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());

        // Print the upper part of the diamond
        for (int i = 1; i <= n; i++)
        {
            PrintSpaces(n - i);
            PrintStars(2 * i - 1);
            Console.WriteLine();
        }

        // Print the lower part of the diamond
        for (int i = n - 1; i > 0; i--)
        {
            PrintSpaces(n - i);
            PrintStars(2 * i - 1);
            Console.WriteLine();
        }
    }

    static void PrintSpaces(int count)
    {
        for (int i = 0; i < count; i++)
        {
            Console.Write(" ");
        }
    }

    static void PrintStars(int count)
    {
        for (int i = 0; i < count; i++)
        {
            Console.Write("*");
        }
    }
}
