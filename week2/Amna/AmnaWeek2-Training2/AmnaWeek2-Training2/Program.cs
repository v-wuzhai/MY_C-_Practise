using System;

namespace DiamondPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;

            while (repeat)
            {
                Console.WriteLine("Enter a number:");
                if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
                {
                    int mid = n / 2;

                    for (int i = 0; i < n; i++)
                    {
                        int stars = i <= mid ? 2 * i + 1 : 2 * (n - i - 1) + 1;
                        int spaces = (n - stars) / 2;
                        Console.WriteLine(new string(' ', spaces) + new string('*', stars));
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }

                Console.WriteLine("Do you want to enter another number? (1 for yes, 2 for no)");
                string response = Console.ReadLine();
                if (response != "1")
                {
                    repeat = false;
                }
            }
        }
    }
}
