using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Average_Grades
{
    class Program
    {
        class Student
        {
            public string Name { get; set; }
            public List<double> Grade { get; set; }
            public double AveraGrade
            {
                get { return Grade.Average(); }
            }
            public Student(string name, List<double> grades)
            {
                Name = name;
                Grade = grades;
            }
        }
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var totalStudents = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split(' ').ToList();
                var name = tokens[0];
                var allGrades = new List<double>();
                for (int q = 1; q < tokens.Count(); q++)
                {
                    allGrades.Add(double.Parse(tokens[q]));
                }
                totalStudents.Add(new Student(name, allGrades));
            }
            foreach (var item in totalStudents.Where(a => a.AveraGrade >= 5).OrderBy(a => a.Name).ThenByDescending(a => a.AveraGrade))
            {
                Console.WriteLine($"{item.Name} -> {item.AveraGrade:f2}");
            }
        }
    }
}
