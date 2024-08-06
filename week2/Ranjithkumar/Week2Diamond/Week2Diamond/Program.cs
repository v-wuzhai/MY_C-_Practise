using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number: ");
        int n = int.Parse(Console.ReadLine());

        PrintDiamond(n);
    }

    static void PrintDiamond(int n)
    {
        int maxStars = 2 * n - 1;

        
        for (int i = 1; i <= n; i++)
        {
            int stars = 2 * i - 1;
            int spaces = (maxStars - stars) / 2;
            Console.WriteLine(new string(' ', spaces) + new string('*', stars));
        }

        
        for (int i = n - 1; i >= 1; i--)
        {
            int stars = 2 * i - 1;
            int spaces = (maxStars - stars) / 2;
            Console.WriteLine(new string(' ', spaces) + new string('*', stars));
        }
    }
}
