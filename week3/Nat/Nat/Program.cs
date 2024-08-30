
using System;
using System.Collections.Generic;
using MyApplication;
class Program
{
    static void Main()
    {

        Console.WriteLine("Hello, Two Sum!\n");
        List<int> num = new List<int>();

        Console.Write("Enter Numbers saparated with spaces: "); //User input numbers
        string[] numberStrings = Console.ReadLine().Split(' ');

        foreach (var numberString in numberStrings)
        {

            if (int.TryParse(numberString, out int nums)) //Parse input to integer
            {

                num.Add(nums);
            }
            else
            {
                Console.WriteLine($"Need to be integer!!!");
                return;
            }
        }

        Console.Write("Enter your target num: "); //User input target number
        if (!int.TryParse(Console.ReadLine(), out int target))
        {
            Console.WriteLine("Need to be an integer!!");
            return;
        }

        int[] result = ListTwoSum.twoSum(num, target); //Call TwoSum method

        if (result != null) //Display result
        {
            Console.WriteLine($"index 1 = {result[0]}, index 2 = {result[1]}");
        }
        else
        {
            Console.WriteLine("Try again!!");
        }
    }
}
