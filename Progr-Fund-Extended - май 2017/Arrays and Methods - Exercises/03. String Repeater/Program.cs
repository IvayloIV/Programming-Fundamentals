using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.String_Repeater
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var n = int.Parse(Console.ReadLine());
            var result = ResultRepeated(text, n);
            Console.WriteLine(result);
        }

        private static string ResultRepeated(string text, int n)
        {
            var result = "";
            for (int i = 0; i < n; i++)
            {
                result += text;
            }
            return result;
        }
    }
}
