using System;

namespace DiamondPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of diamond pattern: ");
            int numberOfRows = int.Parse(Console.ReadLine());

            if (numberOfRows < 1)
            {
                Console.WriteLine("The number of rows must be at least 1.");
                return;
            }

            PrintDiamond(numberOfRows);
        }

        static void PrintDiamond(int rows)
        {
            int n = (rows * 2) - 1;

           
            for (int i = 0; i < rows; i++)
            {
        
                for (int j = 0; j < (rows - i - 1); j++)
                {
                    Console.Write(" ");
                }

               
                for (int j = 0; j < (2 * i + 1); j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            
            for (int i = rows - 2; i >= 0; i--)
            {
                for (int j = 0; j < (rows - i - 1); j++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < (2 * i + 1); j++)
                {
                    Console.Write("*");
                }

              
                Console.WriteLine();
            }
        }
    }
}
