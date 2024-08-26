using System;
using System.Text;

public class CountAndSay
{
    public static string Generate(int n)
    {
        string result = "1";

        for (int i = 1; i < n; i++)
        {
            result = GetNext(result);
        }

        return result;
    }

    private static string GetNext(string term)
    {
        StringBuilder nextTerm = new StringBuilder();
        int i = 0;

        while (i < term.Length)
        {
            char currentChar = term[i];
            int count = 1;

            while (i + 1 < term.Length && term[i + 1] == currentChar)
            {
                i++;
                count++;
            }

            nextTerm.Append(count).Append(currentChar);
            i++;
        }

        return nextTerm.ToString();
    }

    public static void Main()
    {
        Console.Write("Enter the value of n: ");
        if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
        {
            Console.WriteLine($"The {n}th term of the count-and-say sequence is: {Generate(n)}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
        }
    }
}
