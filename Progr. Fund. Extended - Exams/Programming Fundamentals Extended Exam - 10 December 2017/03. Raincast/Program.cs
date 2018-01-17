using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Raincast
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = "";
            var source = "";
            var forecast = "";
            var count = 1;
            while (true) {
                var input = Console.ReadLine();
                if (input == "Davai Emo")
                {
                    break;
                }
                if (count % 3 == 1)
                {

                    Match findingType = Regex.Match(input, @"^Type: (Normal|Warning|Danger)$");
                    if (!findingType.Success)
                    {
                        continue;
                    }
                    type = findingType.Groups[1].Value;
                    count++;
                }
                else if (count % 3 == 2)
                {
                    Match findingSourcs = Regex.Match(input, @"^Source: ([A-Za-z0-9]+)$");
                    if (!findingSourcs.Success)
                    {
                        continue;
                    }
                    source = findingSourcs.Groups[1].Value;
                    count++;
                }
                else if (count % 3 == 0)
                {
                    Match findingForecast = Regex.Match(input, @"^Forecast: ([^\!\.\,\?]+)$");
                    if (!findingForecast.Success)
                    {
                        continue;
                    }
                    forecast = findingForecast.Groups[1].Value;
                    count++;
                    Console.WriteLine($"({type}) {forecast} ~ {source}");
                }
            }
        }
    }
}
