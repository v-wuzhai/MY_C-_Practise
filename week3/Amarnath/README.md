# Two Sum Problem

## Overview

This project finds all pairs of indices in an integer array where the numbers at those indices sum to a given target. It uses a two-pointer technique on a sorted list to efficiently identify pairs.

## Functionality

- **Input**: Number of elements, the elements, and the target value.
- **Process**: Identifies all index pairs that sum to the target.
- **Output**: Prints all valid index pairs in 1-based format.

## Code

### `FindAllTwoSums` Function
- **Purpose**: Finds all pairs of indices that sum to the target.
- **Inputs**: List of integers (`numbers`) and an integer (`target`).
- **Outputs**: List of index pairs.

### `Main` Method
- **Purpose**: Manages user input and displays results.
- **Steps**:
  1. Read number of elements and their values.
  2. Read target value.
  3. Call `FindAllTwoSums` and print results.