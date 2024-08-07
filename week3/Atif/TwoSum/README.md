
TwoSum Program in C#
Overview
This program is designed to find two indices of a sorted array that add up to a given target number. It utilizes the two-pointer technique to efficiently determine the indices.

How It Works
Input Reading:

The program first asks the user to input the number of elements in the array.
The user then inputs each element of the array.
Finally, the user inputs the target sum they are looking for.
TwoSum Algorithm:

The TwoSum function takes a list of integers (numbers) and an integer (target) as input.
It initializes two pointers, left starting from the beginning of the list and right starting from the end of the list.
It then enters a loop where it sums the elements at the left and right pointers:
If the sum equals the target, the function returns a list containing the 1-based indices of these two elements.
If the sum is less than the target, it increments the left pointer to increase the sum.
If the sum is greater than the target, it decrements the right pointer to decrease the sum.
If no such pair is found, the function returns an empty list.
Output:

If a pair is found that sums to the target, the program outputs the 1-based indices of these two elements.
If no pair is found, the program outputs a message indicating there is no solution.