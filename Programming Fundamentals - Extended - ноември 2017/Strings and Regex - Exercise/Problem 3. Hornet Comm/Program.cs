using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem_3.Hornet_Comm
{
    class Program
    {
        class MassagePrivate
        {
            public string Recipient { get; set; }
            public string Message { get; set; }
        }

        class Broatcastt
        {
            public string Recipient { get; set; }
            public string Message { get; set; }
        }
        static void Main(string[] args)
        {
            var privMassage = new List<MassagePrivate>();
            var broatcastta = new List<Broatcastt>();
            while (true)
            {
                var input = Console.ReadLine();

                if (input == "Hornet is Green")
                {
                    break;
                }

                Match privateMassigeFinding = Regex.Match(input, @"^([0-9]+) <-> ([A-Za-z0-9]+$)");
                Match broatcastFinding = Regex.Match(input, @"^([^0-9]+) <-> ([A-Za-z0-9]+)$");

                if (privateMassigeFinding.Success)
                {
                    var newMassage = new MassagePrivate();
                    newMassage.Recipient = new string(privateMassigeFinding.Groups[1].Value.Reverse().ToArray());
                    newMassage.Message = privateMassigeFinding.Groups[2].Value;
                    privMassage.Add(newMassage);
                }
                else if (broatcastFinding.Success)
                {
                    var newBroatcast = new Broatcastt();
                    newBroatcast.Message = broatcastFinding.Groups[1].Value;

                    var currentFren = broatcastFinding.Groups[2].Value;
                    currentFren = BigSmallLetter(currentFren);
                    newBroatcast.Recipient = currentFren;
                    broatcastta.Add(newBroatcast);
                }
            }

            Console.WriteLine("Broadcasts:");

            foreach (var item in broatcastta)
            {
                Console.WriteLine($"{item.Recipient} -> {item.Message}");
            }

            if (broatcastta.Count == 0)
            {
                Console.WriteLine("None");
            }

            Console.WriteLine("Messages:");

            foreach (var item in privMassage)
            {
                Console.WriteLine($"{item.Recipient} -> {item.Message}");
            }

            if (privMassage.Count == 0)
            {
                Console.WriteLine("None");
            }
        }

        private static string BigSmallLetter(string currentFren)
        {
            var result = "";
            for (int i = 0; i < currentFren.Length; i++)
            {
                if (currentFren[i] >= 97 && currentFren[i] <= 122)
                {
                    result += currentFren[i].ToString().ToUpper();
                }
                else if (currentFren[i] >= 65 && currentFren[i] <= 90)
                {
                    result += currentFren[i].ToString().ToLower();
                }
                else
                {
                    result += currentFren[i].ToString();
                }
            }
            return result;
        }
    }
}
