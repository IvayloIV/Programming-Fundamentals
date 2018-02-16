using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Order_by_Age
{
    class Student
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }
        public Student(string name, string id, int age)
        {
            Name = name;
            Id = id;
            Age = age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var book = new List<Student>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                var inputTokens = input.Split(' ').ToArray();
                book.Add(new Student(inputTokens[0], inputTokens[1], int.Parse(inputTokens[2])));
            }
            foreach (var item in book.OrderBy(a => a.Age))
            {
                Console.WriteLine($"{item.Name} with ID: {item.Id} is {item.Age} years old.");
            }
        }
    }
}
