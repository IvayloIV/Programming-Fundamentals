using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Interval_of_Numb
{
    class Program
    {
        static void Main(string[] args)
        {
            var startNum = int.Parse(Console.ReadLine());
            var endNum = int.Parse(Console.ReadLine());

            for (int i = Math.Min(startNum, endNum); i <= Math.Max(startNum, endNum); i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
