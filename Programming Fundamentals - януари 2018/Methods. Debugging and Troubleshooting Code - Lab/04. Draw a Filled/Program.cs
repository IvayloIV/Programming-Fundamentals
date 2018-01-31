using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Draw_a_Filled
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            PrintFooterHeader(n);
            for (int i = 0; i < n - 2; i++)
            {
                PrintBody(n);
            }
            PrintFooterHeader(n);
        }

        private static void PrintBody(int n)
        {
            Console.Write('-');
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine('-');
        }

        private static void PrintFooterHeader(int n)
        {
            Console.WriteLine(new string('-', n * 2));
        }
    }
}
