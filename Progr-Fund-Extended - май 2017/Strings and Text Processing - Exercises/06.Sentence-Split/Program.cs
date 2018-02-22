using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Sentence_Split
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var delimeter = Console.ReadLine();
            var outputArr = input.Split(new string[] { delimeter }, StringSplitOptions.None).ToArray();
            Console.WriteLine("[" + string.Join(", ", outputArr) + "]");
        }
    }
}
