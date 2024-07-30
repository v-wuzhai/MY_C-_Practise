# WEEK 2: Diamond Exercise

## Description

This C# program prints a diamond shape based on a user-provided number. The number determines the size of the diamond. 

## How It Works

1. **Input Reading:**
   - The program prompts the user to enter a number, which specifies the size of the diamond.

2. **Upper Part of the Diamond:**
   - For each row from 1 to the input number `n`, the program prints spaces followed by stars.
   - The number of spaces decreases as the row number increases.
   - The number of stars increases according to the formula `2 * i - 1`, where `i` is the current row number.

3. **Lower Part of the Diamond:**
   - For each row from `n-1` to 1, the program prints spaces followed by stars.
   - The number of spaces increases as the row number decreases.
   - The number of stars decreases according to the formula `2 * i - 1`.

