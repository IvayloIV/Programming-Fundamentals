using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Magic_exchangeable
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split().Select(a => new string(a.Distinct().ToArray())).ToArray();

            var firstWord = words[0];
            var secondWord = words[1];
            if (firstWord.Length != secondWord.Length)
            {
                Console.WriteLine("false");
            }
            else
            {
                Console.WriteLine("true");
            }
        }
    }
}
