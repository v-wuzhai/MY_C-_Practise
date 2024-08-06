using System;
 
class Program
{
    static void Main()
    {
        Console.Write("Enter the number of rows for the diamond: ");
        int n = int.Parse(Console.ReadLine());
        PrintDiamond(n);
    }
    static void PrintDiamond(int n)
    {
        // Print the top half of the diamond
        for (int i = 1; i <= n; i++)
        {
            PrintLine(n, i);
        }
 
        // Print the bottom half of the diamond
        for (int i = n - 1; i >= 1; i--)
        {
            PrintLine(n, i);
        }
    }
 
    static void PrintLine(int n, int i)
    {
        // Print leading spaces
        Console.Write(new string(' ', n - i));
        // Print stars
        Console.Write(new string('*', 2 * i - 1));
        // Move to the next line
        Console.WriteLine();
    }
}