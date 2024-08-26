using System;

public class DiamondPattern
{
    public static void PrintDiamond(int n)
    {
        if (n < 1)
        {
            Console.WriteLine("The number must be a positive integer.");
            return;
        }
        for (int i = 0; i < n; i++)
        {
            Console.Write(new string(' ', n - i - 1));
            Console.WriteLine(new string('*', 2 * i + 1));
        }
        for (int i = n - 2; i >= 0; i--)
        {
            Console.Write(new string(' ', n - i - 1)); 
            Console.WriteLine(new string('*', 2 * i + 1));
        }
    }

    public static void Main()
    {
        Console.Write("Enter a number to print the diamond: ");
        if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
        {
            PrintDiamond(n);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
        }
    }
}
