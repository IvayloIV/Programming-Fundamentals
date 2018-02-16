using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Average_Character_Delim
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var sum = 0;
            var count = 0;
            foreach (var item in arr)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    sum += item[i];
                    count++;
                }
            }
            int averageChar = sum / count;
            Console.WriteLine(string.Join(((char)averageChar).ToString().ToUpper(), arr));
        }
    }
}
