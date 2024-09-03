using System;
using System.Text;

class Program
{
    
    public static string CountAndSay(int n)
    {
        if (n <= 0)
            throw new ArgumentException("n must be a positive integer.");

        string currentTerm = "1";

        for (int i = 1; i < n; i++)
        {
            currentTerm = GetNextTerm(currentTerm);
        }

        return currentTerm;
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

        nextTerm.Append(count);
        nextTerm.Append(term[term.Length - 1]);

        return nextTerm.ToString();
    }

    static void Main()
    {
        try
        {
            Console.Write("Enter the term number (n): ");
            int n = int.Parse(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine("Please enter a positive integer.");
                return;
            }

            string result = CountAndSay(n);
            Console.WriteLine($"The {n}th term of the count-and-say sequence is: {result}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}
