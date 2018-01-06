using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Anonymous_Cache
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
            var allDataSet = new List<string>();

            book = MakeLoopForBook(book, allDataSet);

            PrintResult(book, allDataSet);
        }

        private static Dictionary<string, Dictionary<string, long>> MakeLoopForBook(Dictionary<string, Dictionary<string, long>> book, List<string> allDataSet)
        {
            while (true)
            {
                var input = Console.ReadLine();

                if (input == "thetinggoesskrra")
                {
                    break;
                }

                var currentInput = input.Split(new string[] { " -> ", " | " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (currentInput.Length == 1)
                {
                    allDataSet.Add(currentInput[0]);
                    continue;
                }

                var dataSet = currentInput[2];
                var dataKey = currentInput[0];
                var dataSize = long.Parse(currentInput[1]);

                book = SetBook(dataSet, dataKey, dataSize, book);
            }
            return book;
        }

        private static Dictionary<string, Dictionary<string, long>> SetBook(string dataSet, 
            string dataKey, long dataSize, 
            Dictionary<string, Dictionary<string, long>> book)
        {
            if (!book.ContainsKey(dataSet))
            {
                book[dataSet] = new Dictionary<string, long>();
            }

            if (!book[dataSet].ContainsKey(dataKey))
            {
                book[dataSet][dataKey] = 0;
            }
            book[dataSet][dataKey] += dataSize;
            return book;
        }

        private static void PrintResult(Dictionary<string, Dictionary<string, long>> book, List<string> allDataSet)
        {
            foreach (var item in book.Where(a => allDataSet.Contains(a.Key))
                .OrderByDescending(a => a.Value.Values.Sum()).Take(1))
            {
                Console.WriteLine($"Data Set: {item.Key}, Total Size: {item.Value.Values.Sum()}");
                foreach (var item2 in item.Value)
                {
                    Console.WriteLine($"$.{item2.Key}");
                }
            }
        }
    }
}
