using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

public class Student
{
    public int StudentId { get; set; }
    public string Name { get; set; }
    public int MathScore { get; set; }
    public int EnglishScore { get; set; }
    public int ProgrammingScore { get; set; }
    public int TotalScore => MathScore + EnglishScore + ProgrammingScore; //add all scores
}

public class Program
{
    public static void Main()
    {
        var students = new List<Student>(); //declare student list

        using (var StudentData = new StreamReader("Student.csv")) //read csv file
        {
            var header = StudentData.ReadLine();
            if (header == null) //check if 
            { 
                return; 
            }

            string row;
            while ((row = StudentData.ReadLine()) != null)  //insert each row into string
            {
                var values = row.Split(',');

                if (values.Length != 5) continue; //make sure it reads each column

                if (int.TryParse(values[0], out int studentId) &&  //save into integer data type
                    int.TryParse(values[2], out int mathScore) &&
                    int.TryParse(values[3], out int englishScore) &&
                    int.TryParse(values[4], out int programmingScore))
                {
                    students.Add(new Student  //add to list
                    {
                        StudentId = studentId,
                        Name = values[1],
                        MathScore = mathScore,
                        EnglishScore = englishScore,
                        ProgrammingScore = programmingScore
                    });
                }
            }
        }

        Console.WriteLine("TOTAL SCORE OF ALL STUDENTS");
        Console.WriteLine($"\n{"STUDENT ID",2}   {"NAME",-12}   {"TOTAL SCORES",-10}");
        Console.WriteLine("----------------------------------------");
        foreach (var student in students) //print all students scores
        {
            Console.WriteLine($"{student.StudentId,-10}   {student.Name,-12}   {student.TotalScore,-5}");
        }

        Console.WriteLine("\n\nSTUDENTS PASSED ALL SUBJECTS");  //list students pass all subjects
        var passingStudents = students.Where(s => s.MathScore > 60 && s.EnglishScore > 60 && s.ProgrammingScore > 60);
        foreach (var student in passingStudents)
        {
            Console.WriteLine(student.Name);
        }

        Console.WriteLine("\n\nTOP 3 HIGHEST SCORE STUDENTS");  //list 3 top students 
        Console.WriteLine($"\n{"STUDENT ID",2}   {"NAME",-12}   {"TOTAL SCORES",-10}");
        Console.WriteLine("----------------------------------------");
        var topStudents = students.OrderByDescending(s => s.TotalScore).Take(3);
        foreach (var student in topStudents)
        {
            Console.WriteLine($"{student.StudentId,-10}   {student.Name,-12}   {student.TotalScore,-5}");
        }
    }
}
