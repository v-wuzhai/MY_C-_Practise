using System;

class Diamond
{
    static void Main(string[] arcs)
    {
        int n = 4;
        
        for (int i = 1; i <= n; i++)
        {
            for (int j = i; j < n; j++)
            {
                Console.Write(" ");
            }
            for (int j = 1; j <= (2 * i - 1); j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        for (int i = n - 1; i >= 1; i--)
        {
            for (int j = n; j > i; j--)
            {
                Console.Write(" ");
            }
            for (int j = 1; j <= (2 * i - 1); j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
