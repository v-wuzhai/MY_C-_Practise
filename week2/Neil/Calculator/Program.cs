using System;

public class Solution
{
    public float calc(float a, float b, char op)
    {
        if (op == '+')
            return (a + b);
        if (op == '-')
            return (a - b);
        if (op == '*')
            return (a * b);
        if (op == '/')
            return (a / b);
        if (op == '%')
            return (a % b);
        throw new ArgumentOutOfRangeException("Invalid Operator"); 
    }

    public static void Main(string[] args)
    {
        Solution s = new Solution();
        float num1, num2;
        
        if (args.Length != 3)
        {
            Console.WriteLine("Invalid format");
            return ;
        }
        num1 = float.Parse(args[0]);
        num2 = float.Parse(args[2]);
        string res = Convert.ToString(s.calc(num1, num2, args[1][0]));
        Console.WriteLine(args[0] + " " + args[1] + " " + args[2] + " = " + res);
    }
}
