using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.SoftUni_Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Decrypt!") break;
                var size = Console.ReadLine();
                Match finding = Regex.Match(input, $@"^([0-9]+)([A-Za-z]{{{size}}})([^A-Za-z]*[0-9][^A-Za-z]*)$");
                if (!finding.Success) continue;
                var resultMessage = "";
                var allNumbers = finding.Groups[1].Value + finding.Groups[3].Value;
                var text = finding.Groups[2].Value;
                for (int i = 0; i < allNumbers.Length; i++)
                {
                    if (allNumbers[i] >= 48 && allNumbers[i] <= 57)
                    {
                        var index = int.Parse(allNumbers[i].ToString());
                        if (index <= text.Length - 1)
                        {
                            resultMessage += text[index];
                        }
                    }
                }
                Console.WriteLine($"{text} = {resultMessage}");
            }
        }
    }
}
