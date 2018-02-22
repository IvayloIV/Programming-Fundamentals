using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.User_Logins
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Dictionary<string, string>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "login") break;
                var inputTokens = input.Split(new string[] { " -> " },StringSplitOptions.RemoveEmptyEntries).ToArray();
                book[inputTokens[0]] = inputTokens[1];
            }
            var unsuccessfulLogin = 0;
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end") break;
                var inputTokens = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var name = inputTokens[0];
                var password = inputTokens[1];
                if (book.ContainsKey(name) && book[name] == password)
                {
                    Console.WriteLine($"{name}: logged in successfully");
                }
                else
                {
                    Console.WriteLine($"{name}: login failed");
                    unsuccessfulLogin++;
                }
            }
            Console.WriteLine($"unsuccessful login attempts: {unsuccessfulLogin}");
        }
    }
}
