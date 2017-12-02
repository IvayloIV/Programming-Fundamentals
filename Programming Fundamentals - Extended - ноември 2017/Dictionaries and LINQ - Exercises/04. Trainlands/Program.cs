using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Trainlands
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Dictionary<string, Dictionary<string, long>>();

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "It's Training Men!")
                {
                    break;
                }
                var currrentInput = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (currrentInput.Length == 1)
                {
                    var currrentInput2 = input.Split(new string[] { " = " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    var train1 = currrentInput2[0];
                    var train2 = currrentInput2[1];

                    book[train1] = new Dictionary<string, long>();

                    foreach (var item in book[train2])
                    {
                        book[train1][item.Key] = item.Value; 
                    }
                }
                else
                {
                    var trainName = currrentInput[0];
                    var totalInput = currrentInput[1].Split(new string[] { " : " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    if (totalInput.Length == 1)
                    {
                        var trainName2 = totalInput[0];

                        if (!book.ContainsKey(trainName))
                        {
                            book[trainName] = new Dictionary<string, long>();
                        }
                        foreach (var item in book[trainName2])
                        {
                            book[trainName][item.Key] = item.Value;
                        }
                        book.Remove(trainName2);
                    }
                    else
                    {
                        var wagonName = totalInput[0];
                        var wagonPower = long.Parse(totalInput[1]);

                        if (!book.ContainsKey(trainName))
                        {
                            book[trainName] = new Dictionary<string, long>();
                        }
                        if (!book[trainName].ContainsKey(wagonName))
                        {
                            book[trainName][wagonName] = 0;
                        }
                        book[trainName][wagonName] += wagonPower;
                    }
                }
            }

            foreach (var item in book.OrderByDescending(a => a.Value.Values.Sum()).ThenBy(a => a.Value.Values.Count()))
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
