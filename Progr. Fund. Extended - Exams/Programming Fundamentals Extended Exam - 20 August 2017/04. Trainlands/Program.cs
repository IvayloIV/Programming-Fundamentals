using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Trainlands
{
    class Program
    {
        static void Main(string[] args)
        {
            StartProgram();
        }

        private static void StartProgram()
        {
            var book = new Dictionary<string, Dictionary<string, long>>();
            book = AddTokenInBook(book);
            PringResult(book);
        }

        private static Dictionary<string, Dictionary<string, long>> AddTokenInBook(Dictionary<string, Dictionary<string, long>> book)
        {
            while (true)
            {
                var input = Console.ReadLine();

                if (input == "It's Training Men!")
                {
                    break;
                }

                var inputTokens = input
                    .Split(new string[] { " -> ", " : " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (inputTokens.Length == 3)
                {
                    book = CreateNewTrain(inputTokens, book);

                }
                else if (inputTokens.Length == 2)
                {
                    book = GetTrains(inputTokens, book);
                }
                else if (inputTokens.Length == 1)
                {
                    book = EqualTrains(input, book);
                }
            }
            return book;
        }

        private static Dictionary<string, Dictionary<string, long>> CreateNewTrain(string[] inputTokens, 
            Dictionary<string, Dictionary<string, long>> book)
        {
            var trainName = inputTokens[0];
            var wagonName = inputTokens[1];
            var wagonPower = long.Parse(inputTokens[2]);

            if (!book.ContainsKey(trainName))
            {
                book[trainName] = new Dictionary<string, long>();
            }
            book[trainName][wagonName] = wagonPower;
            return book;
        }

        private static Dictionary<string, Dictionary<string, long>> GetTrains(string[] inputTokens, 
            Dictionary<string, Dictionary<string, long>> book)
        {
            var trainName = inputTokens[0];
            var otherTrainName = inputTokens[1];

            if (!book.ContainsKey(trainName))
            {
                book[trainName] = new Dictionary<string, long>();
            }
            foreach (var item in book[otherTrainName])
            {
                book[trainName].Add(item.Key, item.Value);
            }
            book.Remove(otherTrainName);
            return book;
        }

        private static Dictionary<string, Dictionary<string, long>> EqualTrains(string input, 
            Dictionary<string, Dictionary<string, long>> book)
        {
            var splitTokens = input.Split(new string[] { " = " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var trainName = splitTokens[0];
            var otherTrainName = splitTokens[1];
            book[trainName] = new Dictionary<string, long>();
            foreach (var item in book[otherTrainName])
            {
                book[trainName].Add(item.Key, item.Value);
            }
            return book;
        }

        private static void PringResult(Dictionary<string, Dictionary<string, long>> book)
        {
            foreach (var item in book.OrderByDescending(a => a.Value.Values.Sum()).ThenBy(a => a.Value.Count()))
            {
                Console.WriteLine($"Train: {item.Key}");
                foreach (var item2 in item.Value.OrderByDescending(a => a.Value))
                {
                    Console.WriteLine($"###{item2.Key} - {item2.Value}");
                }
            }
        }
    }
}
