using System;
using System.Collections.Generic;

class Program
{
    public static List<int> TwoSum(List<int> numbers, int target)
    {
        int left = 0, right = numbers.Count - 1;

        while (left < right)
        {
            int currentSum = numbers[left] + numbers[right];
            // If current sum == target, return left and right
            if (currentSum == target)
            {
                if (left + 1 < right + 1)
                {
                    return new List<int> { left + 1, right + 1 };
                }
                else
                {
                    return new List<int> { right + 1, left + 1 };
                }
            }
            // If current sum < target, then increase the
            // current sum by moving the left pointer by 1
            else if (currentSum < target)
            {
                left++;
            }
            else
            {
                // If current sum > target, then decrease the
                // current sum by moving the right pointer by 1
                right--;
            }
        }

        return new List<int>();
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of elements in the array:");
        int n = int.Parse(Console.ReadLine());

        List<int> numbers = new List<int>();
        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < n; i++)
        {
            numbers.Add(int.Parse(Console.ReadLine()));
        }

        Console.WriteLine("Enter the target number:");
        int target = int.Parse(Console.ReadLine());

        List<int> result = TwoSum(numbers, target);

        if (result.Count > 0)
        {
            Console.WriteLine("Index 1: {0},Index 2:{1}", result[0], result[1]);
        }
        else
        {
            Console.WriteLine("There no solution for the target number.");
        }
    }
}
