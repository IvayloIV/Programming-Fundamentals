using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _08.Use_Your_Chains
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            MatchCollection sentences = Regex.Matches(input, @"<p>(.*?)<\/p>");
            var resultText = "";
            foreach (Match item in sentences)
            {
                var total = item.Groups[1].Value;
                for (int i = 0; i < total.Length; i++)
                {
                    if (total[i] >= 97 && total[i] <= 109)
                    {
                        resultText += (char)(total[i] + 13);
                    }
                    else if (total[i] >= 110 && total[i] <= 122)
                    {
                        resultText += (char)(total[i] - 13);
                    }
                    else if (total[i] >= 48 && total[i] <= 57)
                    {
                        resultText += total[i];
                    }
                    else
                    {
                        resultText += " ";
                    }
                }
            }
            resultText = Regex.Replace(resultText, @"\s+", " ");
            Console.WriteLine(resultText);
        }
    }
}
