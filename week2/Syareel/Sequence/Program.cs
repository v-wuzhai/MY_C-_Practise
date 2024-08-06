using System;
using System.Text;

public class CountAndSay
{
    public static string GenerateSequence(int n)
    {
        if (n <= 0) return string.Empty;

        string result = "1";
        for (int i = 1; i < n; i++)
        {
            result = GetNextSequence(result);
        }
        return result;
    }

    private static string GetNextSequence(string sequence)
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
                nextSequence.Append(count).Append(currentChar);
                currentChar = sequence[i];
                count = 1;
            }
        }
        nextSequence.Append(count).Append(currentChar);

        return nextSequence.ToString();
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter the number of terms: ");
        if (int.TryParse(Console.ReadLine(), out int n))
        {
            string result = GenerateSequence(n);
            Console.WriteLine($"The {n}th sequence is: {result}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }
}







