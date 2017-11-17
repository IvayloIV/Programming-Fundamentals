using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Array_Contains_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var number = int.Parse(Console.ReadLine());

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == number)
                {
                    Console.WriteLine("yes");
                    return;
                }
            }

            Console.WriteLine("no");
        }
    }
}
