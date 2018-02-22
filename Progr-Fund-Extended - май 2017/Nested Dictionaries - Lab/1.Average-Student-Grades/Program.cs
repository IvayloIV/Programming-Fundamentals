using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new Dictionary<string, List<double>>();
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var inputTokens = Console.ReadLine().Split(' ').ToArray();
                if (!students.ContainsKey(inputTokens[0]))
                {
                    students[inputTokens[0]] = new List<double>();
                }
                students[inputTokens[0]].Add(double.Parse(inputTokens[1]));
            }
            foreach (var item in students)
            {
                Console.WriteLine($"{item.Key} -> {string.Join(" ", item.Value.Select(a => $"{a:f2}"))} (avg: {(item.Value.Average()):f2})");
            }
        }
    }
}
