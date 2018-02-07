using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrChars = Console.ReadLine().ToCharArray();

            for (int i = 0; i < arrChars.Length; i++)
            {
                var currentChar = arrChars[i];
                Console.WriteLine($"{currentChar} -> {(int)currentChar - 97}");
            }
        }
    }
}
