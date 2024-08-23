using System;
using System.Text;

class Program
{
    static void Main()
    {
        string choice;
        do
        {
            Console.Write("Enter the value of n: ");
            int n = int.Parse(Console.ReadLine());

            string result = CountAndSay(n);
            Console.WriteLine($"The sequence in the count-and-say sequence is: {result}");

            Console.Write("Do you want to create another sequence? (1 for yes, 2 for no): ");
            choice = Console.ReadLine();
        } while (choice == "1");

        Console.WriteLine("Program ended.");
    }

    static string CountAndSay(int n)
    {
        string result = "1";
        for (int i = 1; i < n; i++)
        {
            result = GetNextSequence(result);
        }
        return result;
    }

    static string GetNextSequence(string sequence)
    {
        StringBuilder nextSequence = new StringBuilder();
        int count = 1;
        char currentChar = sequence[0];

        for (int i = 1; i < sequence.Length; i++)
        {
            if (sequence[i] == currentChar)
            {
                count++;
            }
            else
            {
                nextSequence.Append(count);
                nextSequence.Append(currentChar);
                count = 1;
                currentChar = sequence[i];
            }
        }

        nextSequence.Append(count);
        nextSequence.Append(currentChar);

        return nextSequence.ToString();
    }
}
