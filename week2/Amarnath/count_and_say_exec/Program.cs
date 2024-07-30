using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the value of n: ");
        int n = int.Parse(Console.ReadLine());
        string result = GenerateNthTerm(n);
        Console.WriteLine($"The {n} term in the count-and-say sequence is: " + result);
    }

    static string GenerateNthTerm(int n)
    {
        string term = "1";  // Start with the first term
        
        for (int i = 1; i < n; i++)
        {
            term = GetNextTerm(term);
        }
        
        return term;
    }

    static string GetNextTerm(string term)
    {
        string nextTerm = "";
        int count = 1;
        
        for (int i = 1; i < term.Length; i++)
        {
            if (term[i] == term[i - 1])
            {
                count++;
            }
            else
            {
                nextTerm += count.ToString() + term[i - 1];
                count = 1;
            }
        }
        
        nextTerm += count.ToString() + term[term.Length - 1];
        
        return nextTerm;
    }
}
