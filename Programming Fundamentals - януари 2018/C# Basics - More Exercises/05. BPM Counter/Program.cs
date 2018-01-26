using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BPM_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            var bpm = double.Parse(Console.ReadLine());
            var beats = double.Parse(Console.ReadLine());

            var bars = Math.Round(beats / 4, 1);
            int minutes = (int)beats / (int)bpm;
            var secound = Math.Floor(60 * (beats / bpm) - minutes * 60);
            Console.WriteLine($"{bars} bars - {minutes}m {secound}s");
        }
    }
}
