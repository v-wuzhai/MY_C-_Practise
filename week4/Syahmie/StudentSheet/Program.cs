using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Student
{
    public string Name { get; }
    public float Score { get; }

    public Student(string name, float score)
    {
        Name = name;
        Score = score;
    }

    private string FloatToString(float n) => n.ToString();

    private void PrintList(List<Student> list)
    {
        if (list == null) return;

        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine($"Student_{i + 1}:\nName: {list[i].Name}\nScore: {FloatToString(list[i].Score)}\n");
        }
        Console.WriteLine($"Total number of students: {list.Count}\n");
    }

    public void ShowStudentList(List<Student> studentList)
    {
        Console.WriteLine("\n\nStudent List:");
        PrintList(studentList);
    }

    public void ShowStudentsWithScoreAbove60(List<Student> studentList)
    {
        Console.WriteLine("\n\nStudents with score >= 60:");
        var sortedList = studentList.Where(s => s.Score >= 60).OrderBy(s => s.Score).ToList();
        PrintList(sortedList);
    }

    public void ShowTop3Students(List<Student> studentList)
    {
        Console.WriteLine("\n\nTop 3 students:");
        var top3List = studentList.OrderByDescending(s => s.Score).Take(3).ToList();
        PrintList(top3List);
    }
}

class FileProcessor
{
    public List<Student> StudentList { get; } = new List<Student>();
    public bool Failure { get; private set; }

    private void ReadFile(string filename)
    {
        try
        {
            var lines = File.ReadAllLines(filename);
            foreach (var line in lines)
            {
                var row = line.Split(",");
                if (row.Length < 2) continue;

                if (float.TryParse(row[1], out var score))
                {
                    StudentList.Add(new Student(row[0], score));
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"Error! File not found: {filename}");
            Failure = true;
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error reading file: {e.Message}");
            Failure = true;
        }
    }

    public FileProcessor(string filename)
    {
        ReadFile(filename);
    }
}

class Program
{
    static void Action(int choice, Student student, List<Student> studentList)
    {
        switch (choice)
        {
            case 1:
                student.ShowStudentList(studentList);
                break;
            case 2:
                student.ShowStudentsWithScoreAbove60(studentList);
                break;
            case 3:
                student.ShowTop3Students(studentList);
                break;
            case 4:
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }

    static void ShowMenu(Student student, List<Student> studentList)
    {
        while (true)
        {
            Console.WriteLine("\n\n1. Full Student list");
            Console.WriteLine("2. Student list (score >= 60)");
            Console.WriteLine("3. Top 3 students");
            Console.WriteLine("4. Exit");

            if (int.TryParse(Console.ReadLine(), out var choice))
            {
                Action(choice, student, studentList);
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a number between 1 and 4.");
            }
        }
    }

    static void Main(string[] args)
    {
        if (args.Length != 1)
        {
            Console.WriteLine("Wrong number of arguments");
            Console.WriteLine("Usage: dotnet run _PATH_TO_CSV_");
            return;
        }

        var fileProcessor = new FileProcessor(args[0]);
        if (fileProcessor.Failure) return;

        var student = new Student("", 0);
        ShowMenu(student, fileProcessor.StudentList);
    }
}
