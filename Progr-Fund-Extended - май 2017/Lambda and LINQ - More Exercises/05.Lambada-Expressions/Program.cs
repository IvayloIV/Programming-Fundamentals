using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Lambada_Expressions
{
    class Program
    {
        class Properties
        {
            public string Property { get; set; }
            public string AllSelectedObj { get; set; }
            public Properties(string property, string firstSelector)
            {
                Property = property;
                AllSelectedObj = firstSelector;
            }
        }
        static void Main(string[] args)
        {
            var book = new Dictionary<string, Properties>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "lambada")
                {
                    break;
                }
                if (input == "dance")
                {
                    foreach (var item in book)
                    {
                        book[item.Key].AllSelectedObj = $"{item.Key}.{book[item.Key].AllSelectedObj}";
                    }
                }
                else
                {
                    var inputTokens = input.Split(new string[] { " => " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    var selector = inputTokens[0];
                    var typeTokens = inputTokens[1].Split('.');
                    var selectorObject = typeTokens[0];
                    var property = typeTokens[1];
                    if (book.All(a => a.Value.AllSelectedObj != selectorObject))
                    {
                        book[selectorObject] = new Properties(property, selector);
                    }
                    else
                    {
                        book[selectorObject].Property = property;
                    }
                }
            }
            foreach (var item in book)
            {
                Console.WriteLine($"{item.Key} => {item.Value.AllSelectedObj}.{item.Value.Property}");
            }
        }
    }
}
