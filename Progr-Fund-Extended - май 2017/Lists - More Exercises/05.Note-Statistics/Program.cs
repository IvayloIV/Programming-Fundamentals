using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Note_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            var notes = new Dictionary<double, string>
            {
                [261.63] = "C",
                [277.18] = "C#",
                [293.66] = "D",
                [311.13] = "D#",
                [329.63] = "E",
                [349.23] = "F",
                [369.99] = "F#",
                [392.00] = "G",
                [415.30] = "G#",
                [440.00] = "A",
                [466.16] = "A#",
                [493.88] = "B"
            };
            var arr = Console.ReadLine().Split().Select(double.Parse).ToList();
            var totalNotes = new List<string>();
            var naturalsSum = 0d;
            var sharpsSum = 0d;
            foreach (var item in arr)
            {
                var wordsNotes = notes[item];
                if (wordsNotes.Contains("#"))
                {
                    sharpsSum += item;
                } else
                {
                    naturalsSum += item;
                };
                totalNotes.Add(wordsNotes);
            }
            Console.WriteLine($"Notes: {string.Join(" ", totalNotes)}");
            Console.WriteLine($"Naturals: {string.Join(", ", totalNotes.Where(a => !a.Contains("#")))}");
            Console.WriteLine($"Sharps: {string.Join(", ", totalNotes.Where(a => a.Contains("#")))}");
            Console.WriteLine($"Naturals sum: {naturalsSum}");
            Console.WriteLine($"Sharps sum: {sharpsSum}");
        }
    }
}
