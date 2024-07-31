using System;

class DiamondPattern
{
    static void Main()
    {
        int n = 5; // size of the diamond, can be changed as needed
        for (int i = 0; i <= n; i++)
        {
            // print leading spaces
            for (int j = 0; j < n - i; j++)
            {
                Console.Write(" ");
            }
            // print stars
            for (int j = 0; j < 2 * i - 1; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        for (int i = n - 1; i >= 0; i--)
        {
            // print leading spaces
            for (int j = 0; j < n - i; j++)
            {
                Console.Write(" ");
            }
            // print stars
            for (int j = 0; j < 2 * i - 1; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
