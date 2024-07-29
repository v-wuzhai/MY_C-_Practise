using System;

public class Solution
{
    public void print(string msg)
    {
        Console.WriteLine(msg);
    }
    
    public string count_the_number_udipshit(string str)
    {
        int i = 0;
        int n = str.Length;
        string res = "";
    
        while (i < n)
        {
            char count = '1';
            while (i + 1 < n && str[i] == str[i + 1])
            {
                ++i;
                ++count;
            }
            res += count;
            res += str[i];
            ++i;
        }
        return res;
    }
    
    public string just_loop(int n)
    {
        if (n == 1)
            return "1";
        if (n == 2)
            return "11";
        string res = "11";
        for (int i = 3; i <= n; i++)
            res = count_the_number_udipshit(res);
        return res;
    }

    public static void Main(string[] args)
    {
        Solution s = new Solution();
        int term;
        
        if (args.Length != 1)
        {
            s.print("Usage: dotnet run <NUMBER>");
            return ;
        }
        term = Convert.ToInt32(args[0]);
        if (term < 1)
            throw new ArgumentOutOfRangeException("Please enter a number > 0");
        s.print(s.just_loop(term));
    }
}

