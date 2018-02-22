using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.String_Decryption
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            arr = arr.Where(a => a >= 65 && a <= 90).Skip(input[0]).Take(input[1]).ToList();
            foreach (var item in arr)
            {
                Console.Write((char)item);
            }
            Console.WriteLine();
        }
    }
}
