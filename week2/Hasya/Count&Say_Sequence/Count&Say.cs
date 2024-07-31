using System;
using System.Text;

class CountAndSay
{
    static void Main()
    {
        int n = 7; // The term of the sequence we want to generate
        string result = GetCountAndSaySequence(n); // Generate the nth term in the sequence
        Console.WriteLine($"Given an integer n={n}, the nth sequence is \"{result}\"."); // Output the result
    }

    static string GetCountAndSaySequence(int n)
    {
        // Given an integer n, generate the nth sequence.

        // Base cases: return the sequence for n = 1 or n = 2 directly
        if (n == 1) return "1";
        if (n == 2) return "11";

        // Initialize the sequence with the second term "11"
        string str = "11";
        for (int i = 3; i <= n; i++) // Loop from the 3rd term to the nth term
        {
            str += '$'; // Append a delimiter to the end of the current sequence
            int len = str.Length; // Get the length of the modified sequence
            int count = 1; // Initialize the count of matching characters
            StringBuilder temp = new StringBuilder(); // Temporary string to build the next term

            // Process the current sequence to generate the next term
            for (int j = 1; j < len; j++)
            {
                // If the current character doesn't match the previous character
                if (str[j] != str[j - 1])
                {
                    // Append the count of the previous character to temp
                    temp.Append(count);
                    // Append the previous character to temp
                    temp.Append(str[j - 1]);
                    // Reset the count for the new character
                    count = 1;
                }
                else // If the current character matches the previous one
                {
                    // Increment the count of matching characters
                    count++;
                }
            }

            // Update str with the newly generated term
            str = temp.ToString();
        }
        return str; // Return the nth term in the sequence
    }
}
