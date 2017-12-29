using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Hornet_Comm
{
    class Program
    {
        class Messages
        {
            public String Recipient { get; set; }
            public String Message { get; set; }
        }
        static void Main(string[] args)
        {
            var book = new Dictionary<String, List<Messages>>
            {
                ["broadcasts"] = new List<Messages>(),
                ["messages"] = new List<Messages>()
            };

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "Hornet is Green")
                {
                    break;
                }

                Match findingPrivateMassage = Regex.Match(input, @"^([0-9]+) <-> ([0-9A-Za-z]+)$");

                if (findingPrivateMassage.Success)
                {
                    var recipient = new string(findingPrivateMassage.Groups[1].Value.Reverse().ToArray());
                    var message = findingPrivateMassage.Groups[2].Value;
                    var currentMessage = new Messages
                    {
                        Recipient = recipient,
                        Message = message
                    };
                    book["messages"].Add(currentMessage);
                    continue;
                }

                Match findingBroadcast = Regex.Match(input, @"^([^0-9]+) <-> ([0-9A-Za-z]+)$");

                if (!findingBroadcast.Success)
                {
                    continue;
                }

                var frequency = findingBroadcast.Groups[2].Value;
                var messageBroad = findingBroadcast.Groups[1].Value;

                frequency = ConvertToCapitalOrSmall(frequency);
                var newBroadcast = new Messages
                {
                    Recipient = frequency,
                    Message = messageBroad
                };
                book["broadcasts"].Add(newBroadcast);
            }
            PrintResult(book);
        }

        private static void PrintResult(Dictionary<string, List<Messages>> book)
        {
            Console.WriteLine("Broadcasts:");
            if (book["broadcasts"].Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (var item in book["broadcasts"])
                {
                    Console.WriteLine($"{item.Recipient} -> {item.Message}");
                }
            }

            Console.WriteLine($"Messages:");
            if (book["messages"].Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (var item in book["messages"])
                {
                    Console.WriteLine($"{item.Recipient} -> {item.Message}");
                }
            }
        }

        private static string ConvertToCapitalOrSmall(string frequency)
        {
            var newFrequencyBroad = "";
            var messageBroadToChar = frequency.ToCharArray();

            foreach (var item in frequency)
            {
                if (item >= 65 && item <= 90)
                {
                    newFrequencyBroad += item.ToString().ToLower();
                }
                else if (item >= 97 && item <= 122)
                {
                    newFrequencyBroad += item.ToString().ToUpper();
                }
                else
                {
                    newFrequencyBroad += item.ToString();
                }
            }
            return newFrequencyBroad;
        }
    }
}
