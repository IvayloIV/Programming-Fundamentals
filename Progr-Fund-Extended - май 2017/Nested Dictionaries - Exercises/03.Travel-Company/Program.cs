using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Travel_Company
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Dictionary<string, Dictionary<string, int>>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "ready")
                {
                    break;
                }
                var inputTokens = input.Split(':').ToArray();
                var town = inputTokens[0];
                if (!book.ContainsKey(town))
                {
                    book[town] = new Dictionary<string, int>();
                }
                var cities = inputTokens[1].Split(',').ToArray();
                foreach (var item in cities)
                {
                    var tokensItem = item.Split('-').ToArray();
                    var city = tokensItem[0];
                    var seats = int.Parse(tokensItem[1]);
                    book[town][city] = seats;
                }
            }
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "travel time!")
                {
                    break;
                }
                var inputTokens = input.Split(' ').ToArray();
                var town = inputTokens[0];
                var capacity = int.Parse(inputTokens[1]);
                if (capacity < book[town].Sum(a => a.Value))
                {
                    Console.WriteLine($"{town} -> all {capacity} accommodated");
                }
                else
                {
                    Console.WriteLine($"{town} -> all except {capacity - book[town].Sum(a => a.Value)} accommodated");
                }
            }
        }
    }
}
