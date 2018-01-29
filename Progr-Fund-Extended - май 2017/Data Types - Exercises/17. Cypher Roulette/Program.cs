using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Cypher_Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var book = new List<string>();
            var reverse = false;
            var prev = "";
            var text = "";
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();

                if (input == "spin")
                {
                    reverse = !reverse;
                    i--;
                }

                if (reverse == false)
                {
                    text += input;
                }
                else
                {
                    text = input + text;
                }

                if (input == prev)
                {
                    text = "";
                    if (input == "spin") {
                        reverse = !reverse;
                    }
                }
                prev = input;
            }
            text = text.Replace("spin", string.Empty);
            Console.WriteLine(text);
        }
    }
}
