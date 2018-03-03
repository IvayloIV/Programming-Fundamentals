using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Population_Aggregation
{
    class Program
    {
        static void Main(string[] args)
        {
            var countCountry = new Dictionary<string, decimal>();
            var townPopulation = new Dictionary<string, BigInteger>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "stop")
                {
                    break;
                }
                var inputTokens = input.Split(new[] { '\\' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var country = "";
                var town = "";
                var population = BigInteger.Parse(inputTokens[2]);
                inputTokens[0] = RemoveProhibitedSymbol(inputTokens[0]);
                inputTokens[1] = RemoveProhibitedSymbol(inputTokens[1]);
                if (inputTokens[0][0] >= 97 && inputTokens[0][0] <= 122)
                {
                    town = inputTokens[0];
                    country = inputTokens[1];
                }
                else
                {
                    town = inputTokens[1];
                    country = inputTokens[0];
                }
                if (!countCountry.ContainsKey(country))
                {
                    countCountry[country] = 0;
                }
                countCountry[country]++;
                townPopulation[town] = population;
            }
            foreach (var item in countCountry.OrderBy(a => a.Key))
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
            foreach (var item in townPopulation.OrderByDescending(a => a.Value).Take(3))
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }

        private static string RemoveProhibitedSymbol(string currentString)
        {
            var result = "";
            MatchCollection findingWords = Regex.Matches(currentString, @"[^@#$&0-9]+");
            foreach (Match item in findingWords)
            {
                result += item.Value;
            }
            return result;
        }
    }
}
