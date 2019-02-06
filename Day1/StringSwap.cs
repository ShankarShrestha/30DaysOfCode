using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DayCode.Day1
{
    class StringSwap
    {
        public void SwapString()
        {
            Console.Write("Enter the String: ");
            string inputString = Console.ReadLine();

            int stringLength = inputString.Length;
            char firstLetter = inputString[0];
            char lastLetter = inputString[stringLength - 1];
            string remaining = inputString.Substring(1, stringLength - 2);
            string newString = lastLetter + remaining + firstLetter;
            Console.WriteLine("Output: " + newString);
            Console.ReadLine();
        }
    }
}
