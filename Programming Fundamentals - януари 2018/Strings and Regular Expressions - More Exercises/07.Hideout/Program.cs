using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _07.Hideout
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            while (true)
            {
                var tokens = Console.ReadLine().Split(' ').ToArray();
                var currentChar = tokens[0];
                var minCount = int.Parse(tokens[1]);
                Match findingChars = Regex.Match(text, $@"\{currentChar}{{{minCount},}}");
                if (!findingChars.Success) continue;
                Console.WriteLine($"Hideout found at index {findingChars.Index} and it is with size {findingChars.Length}!");
                break;
            }
        }
    }
}
