using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Endurance_Rally
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var trace = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            var indexes = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            foreach (var item in names)
            {
                var isRight = true;
                double firstL = char.Parse(item[0].ToString());
                for (int i = 0; i < trace.Length; i++)
                {
                    if (indexes.Contains(i))
                    {
                        firstL += trace[i];
                    }
                    else
                    {
                        firstL -= trace[i];
                    }
                    if (firstL <= 0)
                    {
                        Console.WriteLine($"{item} - reached {i}");
                        isRight = false;
                        break;
                    }
                }
                if (isRight)
                {
                    Console.WriteLine($"{item} - fuel left {firstL:f2}");
                }
            }
        }
    }
}
