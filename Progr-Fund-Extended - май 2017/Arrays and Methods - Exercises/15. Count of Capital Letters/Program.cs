using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Count_of_Capital_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            var count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length == 1)
                {
                    var currentChar = char.Parse(arr[i]);
                    if (currentChar >= 65 && currentChar <= 90)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
