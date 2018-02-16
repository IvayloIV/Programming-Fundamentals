using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Camels_Back
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToList();
            var m = int.Parse(Console.ReadLine());
            if (m == arr.Count())
            {
                Console.WriteLine($"already stable: {string.Join(" ", arr)}");
                return;
            }
            var rounte = 0;
            while (arr.Count() != m)
            {
                arr.RemoveAt(arr.Count() - 1);
                arr.RemoveAt(0);
                rounte++;
            }
            Console.WriteLine($"{rounte} rounds");
            Console.WriteLine($"remaining: {string.Join(" ", arr)}");
        }
    }
}
