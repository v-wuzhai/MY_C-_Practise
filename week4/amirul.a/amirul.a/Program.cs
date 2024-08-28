// See https://aka.ms/new-console-template for more information
//Amirul Aiman
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;
using StudentScores;
public class Program
{
    public static void Main(string[] args)
    {
        
        string relativePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "score.csv"); //to configure file path
        string fullPath = Path.GetFullPath(relativePath);
        /* Console.WriteLine("Resolved File Path: " + fullPath);*/
        
        List<Student> students = studentScores.studentList(fullPath);

        Console.WriteLine("List of student details\n");
        studentScores.studentDetailsList(students);

        Console.WriteLine("\nList of passed students\n");
        studentScores.studentsPassedList(students);

        Console.WriteLine("\nList of top 3 students\n");
        studentScores.topStudentsList(students);
    }
}