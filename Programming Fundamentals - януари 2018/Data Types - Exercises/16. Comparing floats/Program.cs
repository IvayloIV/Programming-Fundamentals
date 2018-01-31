using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Comparing_floats
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var del = Math.Abs(a - b);
            if (del >= 0.000001)
            {
                Console.WriteLine("False");
            }
            else {
                Console.WriteLine("True");
            }
        }
    }
}
