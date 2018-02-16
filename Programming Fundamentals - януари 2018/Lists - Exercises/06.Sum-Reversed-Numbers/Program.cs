using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var sum = 0;
            foreach (var item in arr)
            {
                sum += int.Parse(new string(item.Reverse().ToArray()));
            }
            Console.WriteLine(sum);
        }
    }
}
