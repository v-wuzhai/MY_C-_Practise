using System;

class Program
{
    static void Main()
    {
        int n = 4;
        PrintDiamond(n);
    }

    static void PrintDiamond(int n)
    {
        
        for (int i = 1; i <= n; i++)
        {
            PrintLine(n, i);
        }

        
        for (int i = n - 1; i >= 1; i--)
        {
            PrintLine(n, i);
        }
    }

    static void PrintLine(int n, int i)
    {
        for (int j = 0; j < n - i; j++)
        {
            Console.Write(" ");
        }

        
        for (int j = 0; j < 2 * i - 1; j++)
        {
            Console.Write("*");
        }

        
        Console.WriteLine();
    }
}