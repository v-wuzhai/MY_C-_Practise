using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

class Student
{
    public string? name {get;}
    public float score {get;}
    public List<Student>? studentList {set; get;}
    private List<Student>? sort60List;
    private List<Student>? top3List;

    private string ftos(float n)
    {
        return string.Format("{0}", n);
    }

    private void printList(List<Student> list)
    {
        if (list == null)
            return ;
        int i = 0;
        foreach (Student s in list)
            Console.WriteLine($"Student_{++i}:\nName: {s.name}\nScore: {ftos(s.score)}\n");
    }

    public void showStudentList()
    {
        Console.WriteLine("\n\nStudent List:");
        if (studentList != null)
            printList(studentList);
    }

    public void sort60()
    {            
        Console.WriteLine("\n\nStudent with score >= 60:");
        if (sort60List == null){
            IEnumerable<Student> scoreQuery =
                from student in studentList
                where student.score >= 60.0f
                orderby student.score
                select student;
            sort60List = scoreQuery.ToList();
        }
        printList(sort60List);
    }

    public void top3()
    {
        Console.WriteLine("\n\nTop 3 students:");
        if (top3List == null){
            IEnumerable<Student> scoreQuery = (
                from student in studentList
                orderby student.score descending
                select student).Take(3);
            top3List = scoreQuery.ToList();
        }
        printList(top3List);
    }

    public Student(string name, float score)
    {
        this.name= name;
        this.score = score;
    }

    public Student() {}
}

class FileProcessor
{
    public List<Student> studentList {get;}
    public bool failure {get;}

    private void readFile(string filename)
    {
        using (var streamReader = File.OpenText(filename))
        {
            var lines = streamReader
                .ReadToEnd()
                .Split("\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines)
            {
                float score;
                var row = line.Split(",", StringSplitOptions.RemoveEmptyEntries);
                if (!float.TryParse(row[1], out score))
                    continue;
                try
                {
                    score = float.Parse(row[1]);
                }
                catch (System.Exception e)
                {
                    Console.WriteLine($"Invalid number format: {row[1]}\n{e.Message}");
                    throw;
                }
                this.studentList.Add(new Student(row[0], score));
            }
        }
    }
    
    public FileProcessor(string filename)
    {
        studentList = new List<Student>();
        this.failure = false;
        try
        {
            readFile(filename);
        }
        catch(FileNotFoundException e)
        {
            Console.WriteLine($"Error ! File not found: {e.FileName}");
            Console.WriteLine("Please specify a valid path.");
            this.failure = true;
        }
    }
}

class Program
{
    private static Student s = new Student();

    static void action(int choice)
    {
        if (choice == 1)
            s.showStudentList();
        else if (choice == 2)
            s.sort60();
        else if (choice == 3)
            s.top3();
        else
            System.Environment.Exit(1);
    }

    static void showMenu()
    {
        while (true)
        {
            Console.Write("\n\n");
            Console.WriteLine("1. Full Student list");
            Console.WriteLine("2. Student list (score > 60)");
            Console.WriteLine("3. Top 3 students");
            Console.WriteLine("4. Exit");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4)
            {
                Console.WriteLine("\nInvalid choice !\nPlese enter number between 1 and 4\n");
                continue;
            }
            action(choice);
        }
    }

    static void Main(string[] args)
    {
        if (args.Length != 1)
        {
            Console.WriteLine("Wrong number of arguments");
            Console.WriteLine("Usage: dotnet run _PATH_TO_CSV_");
            return ;
        }

        FileProcessor fp = new FileProcessor(args[0]);
        if (fp.failure)
            return ;
        s.studentList = fp.studentList;
        showMenu();
    }    
}