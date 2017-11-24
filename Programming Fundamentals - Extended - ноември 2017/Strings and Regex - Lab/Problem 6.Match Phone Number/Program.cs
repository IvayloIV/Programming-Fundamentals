using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem_6.Match_Phone
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            MatchCollection finding = Regex.Matches(input, @"\+359([ |-])2\1[0-9]{3}\1[0-9]{4}\b");

            var p = new List<string>();
            foreach (var item in finding)
            {
                p.Add(item.ToString());
            }
            Console.WriteLine(string.Join(", ", p));
        }
    }
}
