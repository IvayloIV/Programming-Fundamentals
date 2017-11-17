using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(" <= ", Console.ReadLine().Split().Select(decimal.Parse).ToList().OrderBy(a => a)));
        }
    }
}
