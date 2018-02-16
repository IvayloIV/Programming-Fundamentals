using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            var tokens = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            var number = tokens[0];
            var power = tokens[1];

            var indexOfBomb = arr.IndexOf(number);
            while (indexOfBomb != -1)
            {
                var start = Math.Max(0, indexOfBomb - power);
                var end = Math.Min(arr.Count() - 1, indexOfBomb + power);

                for (int i = end; i >= start; i--)
                {
                    arr.RemoveAt(i);
                }
                indexOfBomb = arr.IndexOf(number);
            }
            Console.WriteLine(arr.Sum());
        }
    }
}
