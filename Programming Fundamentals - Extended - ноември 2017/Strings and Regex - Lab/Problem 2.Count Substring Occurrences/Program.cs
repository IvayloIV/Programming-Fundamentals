using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Count_Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToLower();
            var word = Console.ReadLine().ToLower();

            var sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                var currentInput = new string(input.Skip(i).Take(word.Length).ToArray());
                if (currentInput == word)
                {
                    sum++;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
