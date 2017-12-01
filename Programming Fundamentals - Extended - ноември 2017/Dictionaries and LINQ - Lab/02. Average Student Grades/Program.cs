using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var book = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList();
                var name = input[0];
                var grade = double.Parse(input[1]);

                if (!book.ContainsKey(name))
                {
                    book[name] = new List<double>();
                }
                book[name].Add(grade);
            }

            foreach (var item in book)
            {
                Console.WriteLine($"{item.Key} -> {string.Join(" ", item.Value.Select(a => $"{a:f2}"))} (avg: {item.Value.Average():f2})");
            }
        }
    }
}
