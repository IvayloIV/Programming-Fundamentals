using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Email_me
{
    class Program
    {
        static void Main(string[] args)
        {
            var email = Console.ReadLine();
            var index = email.IndexOf('@');
            var leftPart = email.Substring(0, index);
            var rigthPart = email.Substring(index + 1);
            var leftPartSum = leftPart.Sum(a => a);
            var rightPartSum = rigthPart.Sum(a => a);
            if (rightPartSum - leftPartSum > 0)
            {
                Console.WriteLine("She is not the one.");
            }
            else
            {
                Console.WriteLine($"Call her!");
            }
        }
    }
}
