using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem_1.Trainegram
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var input = Console.ReadLine();

                if (input == "Traincode!")
                {
                    break;
                }

                Match finding = Regex.Match(input, @"^((<\[[^A-Za-z0-9]+].)|<\[].)((.\[[A-Za-z0-9]+].)|(.\[].))*$");

                if (finding.Success)
                {
                    Console.WriteLine(input);
                }
            }
        }
    }
}
