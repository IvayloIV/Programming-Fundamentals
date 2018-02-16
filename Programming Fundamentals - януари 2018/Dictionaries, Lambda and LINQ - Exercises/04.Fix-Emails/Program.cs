using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Dictionary<string, string>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "stop")
                {
                    break;
                }
                var email = Console.ReadLine();
                if (email.EndsWith("us") || email.EndsWith("uk"))
                {
                    continue;
                }
                book[input] = email;
            }
            foreach (var item in book)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
