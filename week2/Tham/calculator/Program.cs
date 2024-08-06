using System;
 
namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Console Calculator in C#\n");
                Console.WriteLine("Select an operation:");
                Console.WriteLine("1. Addition (+)");
                Console.WriteLine("2. Subtraction (-)");
                Console.WriteLine("3. Multiplication (*)");
                Console.WriteLine("4. Division (/)");
                Console.WriteLine("5. Exit");
 
                string operation = Console.ReadLine();
 
                if (operation == "5")
                {
                    break;
                }
 
                Console.Write("\nEnter the first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());
 
                Console.Write("Enter the second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());
 
                double result = 0;
 
                switch (operation)
                {
                    case "1":
                        result = num1 + num2;
                        Console.WriteLine($"\nResult: {num1} + {num2} = {result}");
                        break;
                    case "2":
                        result = num1 - num2;
                        Console.WriteLine($"\nResult: {num1} - {num2} = {result}");
                        break;
                    case "3":
                        result = num1 * num2;
                        Console.WriteLine($"\nResult: {num1} * {num2} = {result}");
                        break;
                    case "4":
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                            Console.WriteLine($"\nResult: {num1} / {num2} = {result}");
                        }
                        else
                        {
                            Console.WriteLine("\nError: Division by zero is not allowed.");
                        }
                        break;
                    default:
                        Console.WriteLine("\nPlease choose the operator (1-4).");
                        break;
                }
 
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }
        }
    }
}