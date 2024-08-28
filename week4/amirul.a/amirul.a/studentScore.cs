using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;

namespace StudentScores
{
    public class studentScores
    {
        public static List<Student> studentList(string fullPath)
        {
            using (var reader = new StreamReader(fullPath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                return csv.GetRecords<Student>().ToList();
            }
        }

        public static void studentDetailsList(IEnumerable<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine($"{student.StudentId} {student.Name}: {student.MathScore}, {student.EnglishScore}, {student.ProgramingScore}");
            }
        }

        public static void studentsPassedList(IEnumerable<Student> students)
        {
            var passed = students.Where(sub => sub.MathScore > 60 && sub.EnglishScore > 60 && sub.ProgramingScore > 60);
            foreach (var student in passed)
            {
                Console.WriteLine($"{student.StudentId} {student.Name}: {student.MathScore}, {student.EnglishScore}, {student.ProgramingScore}");
            }
        }

        public static void topStudentsList(IEnumerable<Student> students)
        {
            var topStudents = students.OrderByDescending(sub => sub.TotalScore).Take(3);
            foreach (var student in topStudents)
            {
                Console.WriteLine($"{student.StudentId} {student.Name}: {student.TotalScore}");
            }
        }
    }
    
}
