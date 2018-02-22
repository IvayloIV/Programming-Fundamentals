using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            for (int i = 0; i < text.Length; i++)
            {
                Console.Write(text[text.Length - 1 - i]);
            }
            Console.WriteLine();
        }
    }
}
