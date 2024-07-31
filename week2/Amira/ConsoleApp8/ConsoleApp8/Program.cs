using System;

public class CountAndSaySequence
{
    public static void Main(string[] args)
    {
        int n = 7;  // Generate sequence

        string currentTerm = "1";
        Console.WriteLine(currentTerm);
        
        for (int i = 2; i <= n; i++)
        {
            currentTerm = Term(currentTerm);
            Console.WriteLine(currentTerm);
        }
    }

    public static string Term(string currentTerm)
    {
        System.Text.StringBuilder result = new System.Text.StringBuilder();
        int count = 1;

        for (int i = 1; i < currentTerm.Length; i++)
        {
            if (currentTerm[i] == currentTerm[i - 1])
            {
                count++;
            }
            else
            {
                result.Append(count);
                result.Append(currentTerm[i - 1]);
                count = 1;
            }
        }

        // Append the last set of counts and digits
        result.Append(count);
        result.Append(currentTerm[currentTerm.Length - 1]);

        Console.WriteLine($"The {currentTerm}th term of the count-and-say sequence is: {result}\n"); //print sequence

        return result.ToString();
        
    }
}