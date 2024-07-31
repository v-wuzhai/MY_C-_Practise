int size, row, col, space;
Console.Write("Enter the size: ");
size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

// Print the top half of the diamond
space = size - 1;
for (row = 1; row <= size; row++)
{
    for (col = 1; col <= space; col++)
        Console.Write(" ");
    space--;

    for (col = 1; col <= 2 * row - 1; col++)
        Console.Write("*");

    Console.WriteLine();
}

// Print the bottom half of the diamond
space = 1;
for (row = 1; row <= size - 1; row++)
{
    for (col = 1; col <= space; col++)
        Console.Write(" ");
    space++;

    for (col = 1; col <= 2 * (size - row) - 1; col++)
        Console.Write("*");

    Console.WriteLine();
}

Console.ReadLine();