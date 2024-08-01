﻿using System;
using System.Collections.Generic;

namespace TS{
    class Solution
    {
        public Solution()
        {
            this.arr = new List<float>();
        }

        public void add(float num)
        {
            this.arr.Add(num);
        }

        public void TwoSum(float target)
        {
            if (this.arr.Count < 2)
            {
                Console.WriteLine($"\nNot enough element\nUnable to find TwoSum for this target {target}");
                return ;
            }

            for (int i = 0; i < this.arr.Count; i++)
            {
                for (int j = i + 1; j < this.arr.Count; j++)
                {
                    if (this.arr[i] + this.arr[j] == target)
                    {
                        Console.WriteLine($"Output: index1 = {i + 1}, index2 = {j + 1}");
                        return ;
                    }
                }
            }
            Console.WriteLine($"Unable to find TwoSum for this target {target}");
        }

        private List<float> arr;
    }

    public class MyApp
    {
        private static Solution s = new Solution();

        private static void parseFloat(string s)
        {
            try
            {
                float.Parse(s);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Invalid number format: {e.Message}");
                throw;
            }
        }

        private static void readLine()
        {
            int i = 0;
            while (true)
            {
                Console.WriteLine($"\nEnter {++i}th element of arr : ");
                Console.WriteLine("Enter 'q' to end");
                string? input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    --i;
                    continue ;
                }
                if (input == "q")
                    return ;
                parseFloat(input);
                s.add(float.Parse(input));
            }
        }

        public static void Main()
        {
            Console.Clear();
            readLine();
            Console.WriteLine("\nEnter target : ");
            string? targetStr = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(targetStr))
            {
                Console.WriteLine("\nTarget cannot be empty !");
                Console.WriteLine("Enter target : ");
                targetStr = Console.ReadLine();
            }
            parseFloat(targetStr);
            s.TwoSum(float.Parse(targetStr));
        }   
    }
}