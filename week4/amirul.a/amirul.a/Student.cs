public class Student
{
    public int StudentId { get; set; }
    public string Name { get; set; }
    public int MathScore { get; set; }
    public int EnglishScore { get; set; }
    public int ProgramingScore { get; set; }

    public int TotalScore => EnglishScore + ProgramingScore + MathScore;
}
