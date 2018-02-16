using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Integer_Insertion
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                var index = int.Parse(input[0].ToString());
                var num = int.Parse(input);
                arr.Insert(index, num);
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
