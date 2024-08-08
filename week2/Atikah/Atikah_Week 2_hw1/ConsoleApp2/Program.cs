using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.Write("Enter the value of n: ");
        int n = int.Parse(Console.ReadLine());

        string result = CountAndSay(n);
        Console.WriteLine($"The {n}th sequence in the count-and-say sequence is: {result}");
    }

    static string CountAndSay(int n)
    {
        if (n <= 0)
            return "";

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
