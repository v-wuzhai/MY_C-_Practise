string retry;

do
{
    double nbr1, nbr2;

    Console.Write("\nEnter your first number: ");
    while (!double.TryParse(Console.ReadLine(), out nbr1))
    {
        Console.Write("This is not a valid input.");
        Console.Write("\nEnter your first number: ");
    }

    Console.Write("Enter your second number: ");
    while (!double.TryParse(Console.ReadLine(), out nbr2))
    {
        Console.Write("This is not a valid input.");
        Console.Write("\nEnter your second number: ");
    }
    double result;

    Console.Write("Choose operation (+ OR - OR / OR * : ");
    string operation = Console.ReadLine();

    if (operation == "+")
    {
        result = nbr1 + nbr2;
        Console.WriteLine(result);
    }
    else if (operation == "-")
    {
        result = nbr1 - nbr2;
        Console.WriteLine(result);
    }
    else if (operation == "*")
    {
        result = nbr1 * nbr2;
        Console.WriteLine(result);
    }
    else if (operation == "/")
    {
        result = nbr1 / nbr2;
        Console.WriteLine(result);
    }
    else
    {
        Console.WriteLine("Invalid operation");
    }

    Console.Write("Retry? Y-Yes N-No: "); //retry
    retry = Console.ReadLine();
}
while (retry == "Y");