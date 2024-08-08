# Student Management System

This project is a simple console application written in C# that reads student data from a CSV file, stores it in a list, and provides functionalities to display all students, students with scores >= 60, and the top 3 students based on scores.

## Features

- Read student data from a CSV file.
- Display the full list of students.
- Display students with scores >= 60.
- Display the top 3 students based on scores.
- Count and display the total number of students for each displayed list.

## Requirements

- .NET Core SDK

## Usage

1. Clone the repository or download the source code.
2. Open a terminal and navigate to the project directory.
3. Ensure you have a CSV file with student data in the following format:
    ```
    Name,Score
    Student_1,89.5
    Student_2,67.3
    ...
    ```
4. Run the program using the `dotnet` command, passing the path to the CSV file as an argument:
    ```sh
    dotnet run _PATH_TO_CSV_
    ```
   Replace `_PATH_TO_CSV_` with the actual path to your CSV file.

## Example

```sh
dotnet run students.csv
