using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Weather
{
    class Program
    {
        class Weather
        {
            public double Temperature { get; set; }
            public string TypeOfWeather { get; set; }
        }
        static void Main(string[] args)
        {
            var book = new Dictionary<string, Weather>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end") break;
                Match finding = Regex.Match(input, @"(?<cityName>[A-Z]{2})(?<averageTemp>[0-9]+\.[0-9]+)(?<weather>[A-Za-z]+)(?=\|)");
                if (!finding.Success) continue;
                var cityName = finding.Groups["cityName"].Value;
                if (!book.ContainsKey(finding.Groups["cityName"].Value))
                {
                    book[cityName] = new Weather();
                }
                book[cityName].Temperature = double.Parse(finding.Groups["averageTemp"].Value);
                book[cityName].TypeOfWeather = finding.Groups["weather"].Value;
            }
            foreach (var item in book.OrderBy(a => a.Value.Temperature))
            {
                Console.WriteLine($"{item.Key} => {$"{item.Value.Temperature:f2}"} => {item.Value.TypeOfWeather}");
            }
        }
    }
}
