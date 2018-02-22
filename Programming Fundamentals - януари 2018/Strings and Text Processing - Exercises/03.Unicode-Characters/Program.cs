using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Unicode_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            for (int i = 0; i < text.Length; i++)
            {
                var current = (int)text[i];
                string outputNum = current.ToString("X4");
                Console.Write($"\\u{outputNum.ToLower()}");
            }
            Console.WriteLine();
        }
    }
}
