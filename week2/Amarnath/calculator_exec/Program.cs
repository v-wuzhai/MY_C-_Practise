using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Calculator");

            // Read the first number
            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            // Read the operator
            Console.Write("Enter an operator (+, -, *, /): ");
            char operatorChar = Console.ReadLine()[0];

            // Read the second number
            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;

            // Perform the calculation
            if (operatorChar == '+')
                result = num1 + num2;
            else if (operatorChar == '-')
                result = num1 - num2;
            else if (operatorChar == '*')
                result = num1 * num2;
            else if (operatorChar == '/')
            {
                if (num2 != 0)
                    result = num1 / num2;
                else
                {
                    Console.WriteLine("Error: Division by zero.");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Error: Invalid operator.");
                return;
            }

            // Display the result
            Console.WriteLine($"Result: {result}");
        }
    }
}
