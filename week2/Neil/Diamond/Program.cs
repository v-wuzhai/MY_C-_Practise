using System;

public class Solution
{
    public void diamond(int n)
    {
        int i = 0;
        int spaces = n - 1;
        
        while (++i <= n)
        {
            Console.Write(new string(' ', spaces--));
            Console.WriteLine(new string('*', i * 2 - 1));
        }
        --i;
        ++spaces;
        while (--i > 0)
        {
            Console.Write(new string(' ', ++spaces));
            Console.WriteLine(new string('*', 2 * i - 1));
        }
    }

    public static void Main(string[] args)
    {
        Solution s = new Solution();
        int num;
        
        if (args.Length != 1)
        {
            Console.WriteLine("Usage: dotnet run <NUMBER>");
            return ;
        }
        num = Convert.ToInt32(args[0]);
        if (num < 1)
            throw new ArgumentOutOfRangeException("Please enter a number > 0");
        s.diamond(num);
    }
}
