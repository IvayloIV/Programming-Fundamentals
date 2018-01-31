using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Price_Change
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double limit = double.Parse(Console.ReadLine());
            double lastNum = double.Parse(Console.ReadLine());

            for (int i = 0; i < n - 1; i++)
            {
                double c = double.Parse(Console.ReadLine());
                double div = Proc(lastNum, c); bool isSignificantDifference = IsHavaALimit(div, limit);
                string message = CheckAndGetResult(c, lastNum, div, isSignificantDifference);
                Console.WriteLine(message);
                lastNum = c;
            }
        }

        private static string CheckAndGetResult(double c, double last, double razlika, bool etherTrueOrFalse)
        {
            string to = "";
            if (razlika == 0)
            {
                to = string.Format("NO CHANGE: {0}", c);
            }
            else if (!etherTrueOrFalse)
            {
                to = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", last, c, razlika * 100);
            }
            else if (etherTrueOrFalse && (razlika > 0))
            {
                to = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", last, c, razlika * 100);
            }
            else if (etherTrueOrFalse && (razlika < 0))
                to = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", last, c, razlika * 100);
            return to;
        }

        private static bool IsHavaALimit(double granica, double isDiff)
        {
            if (Math.Abs(granica) >= isDiff)
            {
                return true;
            }
            return false;
        }

        private static double Proc(double a, double b)
        {
            double r = (b - a) / a;
            return r;
        }
    }
}
