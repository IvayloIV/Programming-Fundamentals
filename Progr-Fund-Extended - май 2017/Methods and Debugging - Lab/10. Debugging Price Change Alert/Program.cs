using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Debugging_Price_Change_Alert
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double border = double.Parse(Console.ReadLine());
            double lastNum = double.Parse(Console.ReadLine());

            for (int i = 0; i < n - 1; i++)
            {
                double lastN = double.Parse(Console.ReadLine());
                double div = Proc(lastNum, lastN);
                bool isSignificantDifference = imaliDif(div, border);
                string message = Get(lastN, lastNum, div, isSignificantDifference);

                Console.WriteLine(message);

                lastNum = lastN;
            }           
        }
        private static string Get(double num, double last, double difference, bool isTrue)
        {
            string to = "";
            if (difference == 0)
            {
                to = string.Format("NO CHANGE: {0}", num);
            }
            else if (!isTrue)
            {
                to = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", last, num, difference * 100);
            }
            else if (isTrue && (difference > 0))
            {
                to = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", last, num, difference * 100);
            }
            else if (isTrue && (difference < 0))
                to = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", last, num, difference * 100);
            return to;
        }

        private static bool imaliDif(double granica, double isDiff)
        {
            if (Math.Abs(granica) >= isDiff)
            {
                return true;
            }
            return false;
        }

        private static double Proc(double l, double c)
        {
            double r = (c - l) / l;
            return r;
        }
    }
}
