using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Extract_Sentences
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();
            var sentences = Console.ReadLine().Split(new string[] { ".", "!", "?" }, StringSplitOptions.RemoveEmptyEntries).Select(a => a.Trim()).ToArray();
            foreach (var item in sentences)
            {
                Match finding = Regex.Match(item, $@"\b{word}\b");
                if (finding.Success) Console.WriteLine(item);
            }
        }
    }
}
