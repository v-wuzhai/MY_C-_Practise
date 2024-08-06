using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

class Student
{
    public string? name {get;}
    public List<float> score {get;}

    public float average {get;}

    public void print()
    {
        Console.WriteLine($"\nName: {name}");
        int i = 0;
        foreach (var f in score)
            Console.WriteLine($"Subject_{++i}: {f}");
        Console.WriteLine($"Average Score : {Math.Round(average, 2)}\n");
    }

    public Student(string name, List<float> score)
    {
        this.name= name;
        this.score = score;

        float total = 0;
        foreach (var s in score)
            total += s;
        average = total / score.Count;
    }
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
                List<float> score = new List<float>();
                var row = line.Split(",", StringSplitOptions.RemoveEmptyEntries);
                for (int i = 1; i < row.Length; i++){
                    score.Add(float.Parse(row[i]));
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

class SMS{
    public List<Student>? studentList {set; get;}
    private List<Student>? sort60List;
    private List<Student>? top3List;

    public void sort60()
    {            
        Console.WriteLine("\n\nStudent with score >= 60:");
        if (sort60List == null){
            IEnumerable<Student> scoreQuery =
                from student in studentList
                where student.score.All(score => score > 60.0f)
                select student;
            sort60List = scoreQuery.ToList();
        }
        foreach (var s in sort60List)
            s.print();
        if (top3List == null)
            Console.WriteLine("No student has average score that > 60");
    }

    public void top3()
    {
        Console.WriteLine("\n\nTop 3 students:");
        if (top3List == null){
            IEnumerable<Student> scoreQuery = (
                from student in studentList
                orderby student.average descending
                select student).Take(3);
            top3List = scoreQuery.ToList();
        }
        foreach (var s in top3List)
            s.print();
    }

    public void printStudentLit()
    {
        foreach (var s in studentList)
            s.print();
    }
}

class Program
{
    private static SMS s = new SMS();

    static void action(int choice)
    {
        if (choice == 1)
            s.printStudentLit();
        else if (choice == 2)
            s.sort60();
        else if (choice == 3)
            s.top3();
        else if (choice == 4)
            Console.Clear();
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
            Console.WriteLine("4. Clear Console");
            Console.WriteLine("5. Exit");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 5)
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
            Console.WriteLine("Usage: python csv_generator.py <num_of_student> <num_of_subject>");
            Console.WriteLine("Outfile : student_<num_of_student>_<num_of_subject>.csv");
            Console.WriteLine("Usage: dotnet run <PATH_TO_CSV_FILE>");
            return ;
        }

        FileProcessor fp = new FileProcessor(args[0]);
        if (fp.failure)
            return ;
        s.studentList = fp.studentList;
        showMenu();
    }    
}