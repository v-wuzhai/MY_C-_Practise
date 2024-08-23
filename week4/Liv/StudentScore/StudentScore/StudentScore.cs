using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentScore
{
    internal class StudentScore
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public double MathScore { get; set; }
        public double EnglishScore { get; set; }
        public double ProgrammingScore { get; set; }

        public StudentScore(int studentId, string name, double mathScore, double englishScore, double programmingScore)
        {
            StudentId = studentId;
            Name = name;
            MathScore = mathScore;
            EnglishScore = englishScore;
            ProgrammingScore = programmingScore;
        }
    }
}
