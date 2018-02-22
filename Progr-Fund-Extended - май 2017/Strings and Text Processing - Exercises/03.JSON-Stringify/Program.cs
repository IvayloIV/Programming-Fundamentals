using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.JSON_Stringify
{
    class Program
    {
        class Student
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public List<int> Grades { get; set; }
            public Student(string name, int age, List<int> grades)
            {
                Name = name;
                Age = age;
                Grades = grades;
            }
        }
        static void Main(string[] args)
        {
            var book = new List<Student>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "stringify") break;
                var inputTokens = input.Split(new string[] { " : ", "->" }, StringSplitOptions.RemoveEmptyEntries).Select(a => a.Trim()).ToArray();
                var list = new List<int>();
                if (inputTokens.Count() == 3)
                {
                    list = inputTokens[2].Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToList();
                }
                book.Add(new Student(inputTokens[0], int.Parse(inputTokens[1]), list));
            }
            var printArr = new List<string>();
            foreach (var item in book)
            {
                printArr.Add($"{{name:\"{item.Name}\",age:{item.Age},grades:[{string.Join(", ", item.Grades)}]}}");
            }
            Console.WriteLine($"[{string.Join(",", printArr)}]");
        }
    }
}
