using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hornet_Armada
{
    class Program
    {
        class FeaturesLegion
        {
            public long LastActivity { get; set; }
            public Dictionary<string, long> Soldier { get; set; }
        }
        static void Main(string[] args)
        {
            StartProgram();
        }

        private static void StartProgram()
        {
            var n = int.Parse(Console.ReadLine());
            var book = new Dictionary<string, FeaturesLegion>();
            book = MakeClaculate(n, book);
            PrintResult(book);
        }

        private static Dictionary<string, FeaturesLegion> MakeClaculate(int n, Dictionary<string, FeaturesLegion> book)
        {
            for (int i = 0; i < n; i++)
            {
                var currentInput = Console.ReadLine()
                    .Split(new string[] { " = ", " -> " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                var legionName = currentInput[1];
                var lastActivity = long.Parse(currentInput[0]);
                var splitInput = currentInput[2].Split(':').ToArray();
                var soldierType = splitInput[0];
                var soldierCount = long.Parse(splitInput[1]);

                AddLegions(legionName, lastActivity, soldierType, soldierCount, book);                
            }
            return book;
        }

        private static void AddLegions(string legionName, 
            long lastActivity, 
            string soldierType, 
            long soldierCount, 
            Dictionary<string, FeaturesLegion> book)
        {
            if (!book.ContainsKey(legionName))
            {
                book[legionName] = new FeaturesLegion();
                book[legionName] = AddNewLegion(lastActivity, soldierType, soldierCount);
            }
            else
            {
                if (book[legionName].Soldier.ContainsKey(soldierType))
                {
                    book[legionName].Soldier[soldierType] += soldierCount;
                }
                else
                {
                    book[legionName].Soldier.Add(soldierType, soldierCount);
                }
                if (book[legionName].LastActivity < lastActivity)
                {
                    book[legionName].LastActivity = lastActivity;
                }
            }
        }

        private static FeaturesLegion AddNewLegion(long lastActivity, string soldierType, long soldierCount)
        {
            var currentLegion = new FeaturesLegion();
            currentLegion.LastActivity = lastActivity;
            currentLegion.Soldier = new Dictionary<string, long>();
            currentLegion.Soldier.Add(soldierType, soldierCount);
            return currentLegion;
        }

        private static void PrintResult(Dictionary<string, FeaturesLegion> book)
        {
            var wanntedResult = Console.ReadLine()
                .Split(new[] { "\\" }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            if (wanntedResult.Length > 1)
            {
                LastActivAndSoldierCount(book, wanntedResult);
            }
            else
            {
                LastActivAndLegion(book, wanntedResult);
            }
        }

        private static void LastActivAndLegion(Dictionary<string, FeaturesLegion> book, string[] wanntedResult)
        {
            var soldierType = wanntedResult[0];
            foreach (var item in book
                .OrderByDescending(a => a.Value.LastActivity)
                .Where(a => a.Value.Soldier.ContainsKey(soldierType)))
            {
                Console.WriteLine($"{item.Value.LastActivity} : {item.Key}");
            }
        }

        private static void LastActivAndSoldierCount(Dictionary<string, FeaturesLegion> book, string[] wanntedResult)
        {
            var activity = long.Parse(wanntedResult[0]);
            var solderType = wanntedResult[1];
            var bookFirstCase = new Dictionary<string, long>();

            foreach (var item in book.Where(a => a.Value.LastActivity < activity))
            {
                foreach (var item2 in item.Value.Soldier.Where(a => a.Key == solderType))
                {
                    bookFirstCase[item.Key] = item2.Value;
                }
            }

            foreach (var item in bookFirstCase.OrderByDescending(a => a.Value))
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
