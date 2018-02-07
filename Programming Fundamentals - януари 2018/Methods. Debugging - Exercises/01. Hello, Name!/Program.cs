using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Hello__Name_
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            PrintResult(name);
        }

        private static void PrintResult(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
