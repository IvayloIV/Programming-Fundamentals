using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Even")
                {
                    Console.WriteLine(string.Join(" ", arr.Where(a => a % 2 == 0)));
                    break;
                }
                else if (input == "Odd") {
                    Console.WriteLine(string.Join(" ", arr.Where(a => a % 2 == 1)));
                    break;
                }

                var inputTokens = input.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList();

                if (inputTokens[0] == "Delete")
                {
                    arr.RemoveAll(a => a == int.Parse(inputTokens[1]));
                }
                else if (inputTokens[0] == "Insert")
                {
                    arr.Insert(int.Parse(inputTokens[2]), int.Parse(inputTokens[1]));
                }
            }
        }
    }
}
