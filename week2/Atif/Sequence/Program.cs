using System;
using System.Text;

class CountAndSay
{
    public static string GenerateNthSequence(int n)
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
        
        for (int i = 1; i < sequence.Length; i++)
        {
            if (sequence[i] == sequence[i - 1])
            {
                count++;
            }
            else
            {
                nextSequence.Append(count).Append(sequence[i - 1]);
                count = 1;
            }
        }
        
        // Append the last counted group
        nextSequence.Append(count).Append(sequence[^1]);
        return nextSequence.ToString();
    }

    static void Main(string[] args)
    {
        Console.Write("Enter the value of n: ");
        if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
        {
            string result = GenerateNthSequence(n);
            Console.WriteLine($"The {n}th sequence is: {result}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
        }
    }
}