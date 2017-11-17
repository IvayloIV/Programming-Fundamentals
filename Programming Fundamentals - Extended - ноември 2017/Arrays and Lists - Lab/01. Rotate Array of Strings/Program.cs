using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Rotate_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToArray();

            var output = input[input.Length - 1];
            for (int i = 0; i < input.Length - 1; i++)
            {
                output += " " + input[i];
            }
            Console.WriteLine(output);
        }
    }
}
