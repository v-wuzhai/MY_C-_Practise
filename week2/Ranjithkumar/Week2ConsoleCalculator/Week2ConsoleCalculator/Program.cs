using System;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueCalculating = true;

            while (continueCalculating)
            {
                Console.Clear();
                Console.WriteLine("Console Calculator\n");

                Console.Write("Enter first number: ");
                double num1 = double.Parse(Console.ReadLine());

                Console.Write("Enter an operator (+, -, *, /): ");
                char op = Console.ReadKey().KeyChar;
                Console.WriteLine();

                Console.Write("Enter second number: ");
                double num2 = double.Parse(Console.ReadLine());

                double result = 0;

                switch (op)
                {
                    case '+':
                        result = num1 + num2;
                        break;
                    case '-':
                        result = num1 - num2;
                        break;
                    case '*':
                        result = num1 * num2;
                        break;
                    case '/':
                        if (num2 != 0)
                            result = num1 / num2;
                        else
                            Console.WriteLine("Error! Division by zero.");
                        break;
                    default:
                        Console.WriteLine("Invalid operator");
                        break;
                }

                Console.WriteLine($"Result: {result}");
                Console.Write("Do you want to perform another calculation? (y/n): ");
                continueCalculating = Console.ReadKey().KeyChar == 'y';
            }
        }
    }
}
