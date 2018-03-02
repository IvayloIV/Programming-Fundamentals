using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var phrases = new List<string>
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product."
            };
            var events = new List<string>
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };
            var authors = new List<string>
            {
                "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva"
            };
            var cities = new List<string>
            {
                "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse"
            };
            var random = new Random();
            var output = new List<string>();
            for (int i = 0; i < n; i++)
            {
                var curretPhrases = random.Next(0, phrases.Count());
                var curretEvents = random.Next(0, events.Count());
                var curretAuthors = random.Next(0, authors.Count());
                var curretCities = random.Next(0, cities.Count());
                output.Add($"{phrases[curretPhrases]} {events[curretEvents]} {authors[curretAuthors]} – {cities[curretCities]}");
            }
            File.WriteAllLines("output.txt", output);
        }
    }
}
