int size, r, s, space;
Console.Write("Enter diamond size: ");
size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

// Print the top half of the diamond
space = size - 1;
for (r = 1; r <= size; r++)
{
    for (s = 1; s <= space; s++)
        Console.Write(" ");
    space--;

    for (s = 1; s <= 2 * r - 1; s++)
        Console.Write("*");

    Console.WriteLine();
}

// Print the bottom half of the diamond
space = 1;
for (r = 1; r <= size - 1; r++)
{
    for (s = 1; s <= space; s++)
        Console.Write(" ");
    space++;

    for (s = 1; s <= 2 * (size - r) - 1; s++)
        Console.Write("*");

    Console.WriteLine();
}

Console.ReadLine();