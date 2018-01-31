using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            var start = int.Parse(Console.ReadLine());
            var end = int.Parse(Console.ReadLine());

            Console.Write((char)start);
            for (int i = start + 1; i <= end; i++)
            {
                Console.Write(" " + (char)i);
            }
            Console.WriteLine();
        }
    }
}
