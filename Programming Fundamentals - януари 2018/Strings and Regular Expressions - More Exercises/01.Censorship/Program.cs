using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Censorship
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();
            var sentence = Console.ReadLine();
            sentence = sentence.Replace(word, new string('*', word.Length));
            Console.WriteLine(sentence);
        }
    }
}
