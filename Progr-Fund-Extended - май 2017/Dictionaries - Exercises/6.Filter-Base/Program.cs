using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Filter_Base
{
    class Program
    {
        static void Main(string[] args)
        {
            var bookAge = new Dictionary<string, int>();
            var bookSalary = new Dictionary<string, double>();
            var bookPosition = new Dictionary<string, string>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "filter base")
                {
                    break;
                }
                var inputTokens = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var name = inputTokens[0];
                if (int.TryParse(inputTokens[1], out int n))
                {
                    bookAge[name] = n;
                }
                else if (double.TryParse(inputTokens[1], out double d))
                {
                    bookSalary[name] = d;
                }
                else
                {
                    bookPosition[name] = inputTokens[1];
                }
            }
            var typeOutput = Console.ReadLine();
            PrintResult(typeOutput, bookAge, bookPosition, bookSalary);
        }

        private static void PrintResult(string typeOutput, Dictionary<string, int> bookAge, Dictionary<string, string> bookPosition, Dictionary<string, double> bookSalary)
        {
            if (typeOutput == "Age")
            {
                foreach (var item in bookAge)
                {
                    Console.WriteLine($"Name: {item.Key}");
                    Console.WriteLine($"Age: {item.Value}");
                    Console.WriteLine(new string('=', 20));
                }
            }
            else if (typeOutput == "Salary")
            {
                foreach (var item in bookSalary)
                {
                    Console.WriteLine($"Name: {item.Key}");
                    Console.WriteLine($"Salary: {item.Value:f2}");
                    Console.WriteLine(new string('=', 20));
                }
            }
            else if (typeOutput == "Position")
            {
                foreach (var item in bookPosition)
                {
                    Console.WriteLine($"Name: {item.Key}");
                    Console.WriteLine($"Position: {item.Value}");
                    Console.WriteLine(new string('=', 20));
                }
            }
        }
    }
}
