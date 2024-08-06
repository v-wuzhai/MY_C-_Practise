using System;

class CountAndSay
{
    // Function to generate the nth term of the count-and-say sequence
    public static string Generate(int n)
    {
        if (n <= 0) throw new ArgumentException("n must be a positive integer.");

        // Start with the first term in the sequence
        string term = "1";

        for (int i = 1; i < n; i++)
        {
            term = GetNextTerm(term);
        }

        return term;
    }

    // Function to compute the next term based on the current term
    private static string GetNextTerm(string term)
    {
        string result = "";
        int count = 1;

        // Iterate over the term to count consecutive digits
        for (int i = 1; i < term.Length; i++)
        {
            if (term[i] == term[i - 1])
            {
                count++;
            }
            else
            {
                // Append the count and the digit to the result
                result += count.ToString() + term[i - 1];
                count = 1;
            }
        }

        // Append the count and the last digit
        result += count.ToString() + term[term.Length - 1];

        return result;
    }

    // Main function to test the implementation
    public static void Main()
    {
        Console.Write("Enter your sequence: ");
        int n = Convert.ToInt32(Console.ReadLine());
        // Example: Generate the 5th term of the count-and-say sequence

        string result = Generate(n);
        Console.WriteLine($"The {n}th term of the count-and-say sequence is: {result}");
    }
}
