using System;
 
class DiamondPattern
{
    public static void Main(string[] args)
    {
        int n = 4;  // Change this to generate a diamond pattern of a different size
        PrintDiamond(n);
    }
 
    public static void PrintDiamond(int n)
    {
        // Print the upper part of the diamond
        for (int i = 1; i <= n; i++)
        {
            for (int j = i; j < n; j++)
            {
                Console.Write(" ");
            }
            for (int k = 1; k < (i * 2); k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
 
        // Print the lower part of the diamond
        for (int i = n - 1; i >= 1; i--)
        {
            for (int j = n; j > i; j--)
            {
                Console.Write(" ");
            }
            for (int k = 1; k < (i * 2); k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}