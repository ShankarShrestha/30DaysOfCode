using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DayCode.Day1
{
    class Average
    {
        public void FindAverage()
        {
            Console.Write("Enter the First Number: ");
            int inputNumber1 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter the Second Number: ");
            int inputNumber2 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter the Third Number: ");
            int inputNumber3 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter the Forth Number: ");
            int inputNumber4 = Int32.Parse(Console.ReadLine());

            float average = (inputNumber1 + inputNumber2 + inputNumber3 + inputNumber4) / 4;

            Console.WriteLine("The average is: " + average);
            Console.ReadLine();
        }
    }
}
