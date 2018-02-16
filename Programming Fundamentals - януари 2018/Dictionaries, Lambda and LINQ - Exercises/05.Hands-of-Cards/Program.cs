using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Hands_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Dictionary<string, List<string>>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "JOKER")
                {
                    break;
                }
                var inputTokens = input.Split(':').ToArray();
                var name = inputTokens[0].Trim();
                var cards = inputTokens[1].Trim();
                var listOfCards = cards.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();
                if (!book.ContainsKey(name))
                {
                    book[name] = new List<string>();
                }
                foreach (var currentCard in listOfCards)
                {
                    if (!book[name].Contains(currentCard))
                    {
                        book[name].Add(currentCard);
                    }
                }
            }
            var powersOfCards = new Dictionary<string, int>
            {
                ["J"] = 11,
                ["Q"] = 12,
                ["K"] = 13,
                ["A"] = 14
            };
            var typesOfCards = new Dictionary<string, int>
            {
                ["S"] = 4,
                ["H"] = 3,
                ["D"] = 2,
                ["C"] = 1
            };
            foreach (var person in book)
            {
                var name = person.Key;
                var powerOfCard = 0;
                foreach (var card in person.Value)
                {
                    var t = card[card.Length - 1];
                    var p = new string(card.Take(card.Length - 1).ToArray());
                    var currentPower = 0;
                    var currentType = 0;
                    if (!powersOfCards.ContainsKey(p))
                    {
                        currentPower += int.Parse(p);
                    }
                    else
                    {
                        currentPower += powersOfCards[p];
                    }
                    currentType += typesOfCards[t.ToString()];
                    powerOfCard += (currentPower * currentType);
                }
                Console.WriteLine($"{name}: {powerOfCard}");
            }
        }
    }
}
