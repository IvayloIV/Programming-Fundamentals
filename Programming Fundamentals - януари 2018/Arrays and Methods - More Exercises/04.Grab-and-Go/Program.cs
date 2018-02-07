using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Grab_and_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var num = int.Parse(Console.ReadLine());

            var index = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                {
                    index = i;
                }
            }
            if (index == -1)
            {
                Console.WriteLine("No occurrences were found!");
                return;
            }

            long sum = 0;

            for (int i = 0; i < index; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine(sum);
        }
    }
}
