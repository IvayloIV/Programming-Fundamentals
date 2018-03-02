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
        class Broadcast
        {
            public string Frequency { get; set; }
            public string Message { get; set; }
            public Broadcast(string frequency, string message)
            {
                Frequency = frequency;
                Message = message;
            }
        }
        class Message
        {
            public string Recipient { get; set; }
            public string TotalMessage { get; set; }
            public Message(string recipient, string message)
            {
                Recipient = recipient;
                TotalMessage = message;
            }
        }
        static void Main(string[] args)
        {
            var broadcasts = new List<Broadcast>();
            var messages = new List<Message>();

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Hornet is Green") break;
                Match isMessage = Regex.Match(input, @"^([0-9]+)\s<->\s([0-9A-Za-z]+)$");
                Match isBroadcast = Regex.Match(input, @"^([^0-9]+)\s<->\s([A-Za-z0-9]+)$");
                if (isMessage.Success)
                {
                    var recipient = new string(isMessage.Groups[1].Value.Reverse().ToArray());
                    var message = isMessage.Groups[2].Value;
                    messages.Add(new Message(recipient, message));
                }
                else if (isBroadcast.Success)
                {
                    var message = isBroadcast.Groups[1].Value;
                    var frequency = isBroadcast.Groups[2].Value;
                    var convertedFrequency = ConvertFrequncy(frequency);
                    broadcasts.Add(new Broadcast(convertedFrequency, message));
                }
            }
            PrintResult(broadcasts, messages);          
        }

        private static void PrintResult(List<Broadcast> broadcasts, List<Message> messages)
        {
            Console.WriteLine($"Broadcasts:");
            if (broadcasts.Count() == 0)
            {
                Console.WriteLine($"None");
            }
            foreach (var item in broadcasts)
            {
                Console.WriteLine($"{item.Frequency} -> {item.Message}");
            }
            Console.WriteLine($"Messages:");
            if (messages.Count() == 0)
            {
                Console.WriteLine($"None");
            }
            foreach (var item in messages)
            {
                Console.WriteLine($"{item.Recipient} -> {item.TotalMessage}");
            }
        }

        private static string ConvertFrequncy(string frequency)
        {
            var result = "";
            for (int i = 0; i < frequency.Length; i++)
            {
                if (frequency[i] >= 65 && frequency[i] <= 90)
                {
                    result += frequency[i].ToString().ToLower();
                }
                else if (frequency[i] >= 97 && frequency[i] <= 122)
                {
                    result += frequency[i].ToString().ToUpper();
                }
                else
                {
                    result += frequency[i];
                }
            }
            return result;
        }
    }
}
