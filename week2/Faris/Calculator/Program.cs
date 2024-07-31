string retry;

do
{
    double num1, num2;

    Console.Write("\nEnter first number : ");
    while (!double.TryParse(Console.ReadLine(), out num1))
    {
        Console.Write("This is not a valid input.");
        Console.Write("\nEnter first number : ");
    }

    Console.Write("Enter second number : ");
    while (!double.TryParse(Console.ReadLine(), out num2))
    {
        Console.Write("This is not a valid input.");
        Console.Write("\nEnter second number : ");
    }
    double result;

    Console.Write("Choose operation (+ OR - OR / OR * : ");
    string ope = Console.ReadLine();

    if (ope == "+")
    {
        result = num1 + num2;
        Console.WriteLine(result);
    }
    else if (ope == "-")
    {
        result = num1 - num2;
        Console.WriteLine(result);
    }
    else if (ope == "*")
    {
        result = num1 * num2;
        Console.WriteLine(result);
    }
    else if (ope == "/")
    {
        result = num1 / num2;
        Console.WriteLine(result);
    }
    else
    {
        Console.WriteLine("Invalid operation");
    }

    Console.Write("Retry ? y-Yes n-No : "); //if user want to retry
    retry = Console.ReadLine();
}
while (retry == "y");