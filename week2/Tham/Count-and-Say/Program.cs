using System;
using System.Text;
 
class CountAndSay
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the value of n: ");
        int n = int.Parse(Console.ReadLine());
        string result = CountAndSaySequence(n);
        Console.WriteLine($"The {n}th term of the count-and-say sequence is: {result}");
    }
 
    public static string CountAndSaySequence(int n)
    {
        if (n <= 0)
            return "";
 
        string result = "1";
 
        for (int i = 1; i < n; i++)
        {
            result = GenerateNextTerm(result);
        }
 
        return result;
    }
 
    private static string GenerateNextTerm(string term)
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
}