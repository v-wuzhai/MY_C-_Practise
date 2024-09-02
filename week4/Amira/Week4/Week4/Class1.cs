using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Student
{
    public int StudentId { get; set; }
    public string? Name { get; set; } = string.Empty;
    public int MathScore { get; set; }
    public int EnglishScore { get; set; }
    public int ProgrammingScore { get; set; }
    public int TotalScore => MathScore + EnglishScore + ProgrammingScore;
    public bool PassedAllSubjects => MathScore > 60 && EnglishScore > 60 && ProgrammingScore > 60;
}

public class FileReader
{
    private readonly string _filePath;

    public FileReader(string filePath)
    {
        _filePath = filePath;
    }

    public List<Student> GetStudents()
    {
        if (!File.Exists(_filePath))
        {
            Console.WriteLine("File not found.");
            return new List<Student>();
        }

        var students = new List<Student>();

        try
        {
            // Skip header line
            foreach (var line in File.ReadLines(_filePath).Skip(1)) 
            {
                var parts = line.Split(',');
                if (parts.Length < 5 ||
                    !int.TryParse(parts[0], out var studentId) ||
                    !int.TryParse(parts[2], out var mathScore) ||
                    !int.TryParse(parts[3], out var englishScore) ||
                    !int.TryParse(parts[4], out var programmingScore))
                {
                    Console.WriteLine($"Skipping invalid line: {line}");
                    continue;
                }

                students.Add(new Student
                {
                    StudentId = studentId,
                    Name = parts[1],
                    MathScore = mathScore,
                    EnglishScore = englishScore,
                    ProgrammingScore = programmingScore
                });
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine($"An IO error occurred: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }

        return students;
    }
}

class Program
{
    static void Main()
    {
        // Construct the relative path to the file
        var relativePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "students_scores.csv");
        var fullPath = Path.GetFullPath(relativePath);

        Console.WriteLine($"Attempting to read file from: {fullPath}");

        var fileReader = new FileReader(fullPath);
        var students = fileReader.GetStudents();

        // 1.  Get all student total score;
        Console.WriteLine("\nAll student total scores:");
        foreach (var student in students)
        {
            Console.WriteLine($"{student.Name}: {student.TotalScore}");
        }

        // 2. Print student name If he passes(>60) all his subjects
        Console.WriteLine("\nStudents who passed all subjects (>60):");
        foreach (var student in students.Where(s => s.PassedAllSubjects))
        {
            Console.WriteLine(student.Name);
        }

        // 3. Print top 3 student order by total score
        Console.WriteLine("\nTop 3 students by total score:");
        foreach (var student in students.OrderByDescending(s => s.TotalScore).Take(3))
        {
            Console.WriteLine($"{student.Name}: {student.TotalScore}");
        }
    }
}
