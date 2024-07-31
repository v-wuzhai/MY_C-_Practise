using System;
using System.Text;

class CountAndSay
{
    public static string GenerateSequence(int n)
    {
        if (n <= 0)
            return "";

        // Start with the base case
        string result = "1";

        // Generate the sequence up to the nth term
        for (int i = 1; i < n; i++)
        {
            result = GetNextTerm(result);
        }

        return result;
    }

    private static string GetNextTerm(string term)
    {
        StringBuilder nextTerm = new StringBuilder();
        int count = 1;

        for (int i = 1; i < term.Length; i++)
        {
            if (term[i] == term[i - 1])
            {
                count++;
            }
            else
            {
                nextTerm.Append(count);
                nextTerm.Append(term[i - 1]);
                count = 1;
            }
        }

        // Append the last group
        nextTerm.Append(count);
        nextTerm.Append(term[term.Length - 1]);

        return nextTerm.ToString();
    }

    static void Main()
    {
        // Example usage
        Console.WriteLine("Enter the term number to generate:");
        int n = int.Parse(Console.ReadLine());

        string sequence = GenerateSequence(n);
        Console.WriteLine($"The {n}th term in the count-and-say sequence is: {sequence}");
    }
}
