using System;
using System.Text;

public class CountAndSay
{
    public static string GenerateSequence(int n)
    {
        if (n <= 0) return "";
        
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
                nextSequence.Append(count);
                nextSequence.Append(sequence[i - 1]);
                count = 1;
            }
        }
        
        // Append the last counted character
        nextSequence.Append(count);
        nextSequence.Append(sequence[sequence.Length - 1]);
        
        return nextSequence.ToString();
    }

    public static void Main()
    {
        Console.WriteLine("Please enter the value of n:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine($"The {n}th sequence is: {GenerateSequence(n)}");
    }
}
