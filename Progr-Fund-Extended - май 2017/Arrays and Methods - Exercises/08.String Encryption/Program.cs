using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.String_Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var output = "";
            for (int i = 0; i < n; i++)
            {
                var num = (int)char.Parse(Console.ReadLine());               
                output += GetEncodingMessage(num);               
            }
            Console.WriteLine(output);
        }

        private static string GetEncodingMessage(int num)
        {
            var firstInt = num.ToString()[0];
            var lastInt = num.ToString()[num.ToString().Length - 1];
            var leftChar = (char)(int.Parse(lastInt.ToString()) + num);
            var rightChar = (char)(num - int.Parse(firstInt.ToString()));
            return $"{leftChar}{firstInt}{lastInt}{rightChar}";
        }
    }
}
