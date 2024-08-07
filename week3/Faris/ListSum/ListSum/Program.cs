using System.Drawing;
internal class Program
{
    private static void Main(string[] args)
    {
        List<int> numberList = new List<int>();
        string answer;
        int number;

        while (true)
        {
            Console.Write("\nEnter an integer to be added into the list. Enter 'x' to finish adding : ");
            answer = Console.ReadLine();
            if (answer == "x")
            {
                break;
            }

            if (!int.TryParse(answer, out number))
            {
                Console.WriteLine("This is not a valid input.");
            }
            else
            {
                numberList.Add(number);
                Console.WriteLine($"Added {number} to the list.");
            }

        }

        int length = numberList.Count;

        Console.WriteLine("\nThe integers in the list right now : ");
        Console.Write("\nIntegers     : [ ");
        for (int i = 0; i < length; i++)
        {
            Console.Write($" {numberList[i]} ");
        }
        Console.Write(" ]");
        Console.Write("\nIndex        : [ ");
        for (int i = 0; i < length; i++)
        {
            Console.Write($" {i + 1} ");
        }
        Console.Write(" ]");

        int sum;

        Console.Write("\n\nEnter the total sum you want to get : ");
        while (!int.TryParse(Console.ReadLine(), out sum))
        {
            Console.WriteLine("\nThis is not a valid input.");
            Console.WriteLine("\nEnter the total sum you want to get : ");
        }

        int stat = 0;
        int sum2;

        for (int i = 0; i < length; i++)
        {
            for (int j = i + 1; j < length; j++)
            {
                sum2 = numberList[i] + numberList[j];
                if (sum2 == sum)
                {
                    if (i != j)
                    {
                        Console.WriteLine($"\nFirst integer {numberList[i]} and Second integer {numberList[j]}");
                        Console.WriteLine($"The index are {i + 1} and {j + 1}");
                        stat = 1;
                    }

                }
            }

        }
        if (stat != 1)
        {
            Console.WriteLine("There's no possible summation");
        }
    }
}