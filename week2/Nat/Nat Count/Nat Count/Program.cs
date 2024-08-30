
class Program
{
    static string CountAndSay(int seq)
    {
        if (seq == 1) return "1";

        string result = "1";

        for (int i = 2; i <= seq; i++)
        {
            string current = "";
            int count = 1;
            char say = result[0];

            for (int j = 1; j < result.Length; j++)
            {
                if (result[j] == say)
                {
                    count++;
                }
                else
                {
                    current += count.ToString() + say;
                    count = 1;
                    say = result[j];
                }
            }

            current += count.ToString() + say;
            result = current;
        }

        return result;
    }

    static void Main()
    {
        Console.WriteLine("Hello, Count and say!");
        string retry;
        do
        {
            Console.Write("Enter sequence : ");
            int seq = Convert.ToInt32(Console.ReadLine());    //enter term
            Console.WriteLine($"Answer : {CountAndSay(seq)}");
            Console.Write("\nRetry ? \ny-Yes n-No : "); //to retry
            retry = Console.ReadLine();
            Console.WriteLine("");
        }
        while (retry == "y");

    }
}