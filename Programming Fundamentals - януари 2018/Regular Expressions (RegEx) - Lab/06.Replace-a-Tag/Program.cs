using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06.Replace_a_Tag
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                var replceText = Regex.Replace(input, @"<a(.*?)href(.*?)=""(.*?)"">(.*?)<\/a>", $"[URL href=\"$3\"]$4[/URL]");
                Console.WriteLine(replceText);
            }
        }
    }
}
