using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.User_Logs
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Dictionary<string, Dictionary<string, int>>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                var inputTokes = input.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var ipTokens = inputTokes[0].Split('=');
                var userTokens = inputTokes[2].Split('=');
                var ip = ipTokens[1];
                var user = userTokens[1];
                if (!book.ContainsKey(user))
                {
                    book[user] = new Dictionary<string, int>();
                }
                if (!book[user].ContainsKey(ip))
                {
                    book[user][ip] = 0;
                }
                book[user][ip]++;
            }
            foreach (var item in book.OrderBy(a => a.Key))
            {
                Console.WriteLine($"{item.Key}: ");
                var outputList = new List<string>();
                foreach (var item2 in item.Value)
                {
                    outputList.Add($"{item2.Key} => {item2.Value}");
                }
                Console.WriteLine(string.Join(", ", outputList) + '.');
            }
        }
    }
}
