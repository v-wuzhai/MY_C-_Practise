using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the value of n: ");
        int n = int.Parse(Console.ReadLine());

        string result = CountAndSay(n);
        Console.WriteLine($"The {n}th sequence is: {result}");
    }

    static string CountAndSay(int n)
    {
        if (n <= 0) return "";

        string sequence = "1";

        for (int i = 1; i < n; i++)
        {
            sequence = GetNextSequence(sequence);
        }

        return sequence;
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
                currentChar = sequence[i];
                count = 1;
            }
        }

        
        nextSequence.Append(count);
        nextSequence.Append(currentChar);

        return nextSequence.ToString();
    }
}

