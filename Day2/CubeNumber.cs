using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DayCode.Day2
{
    class CubeNumber
    {
        //  Write a program in C# Sharp to display the cube of the number upto given an integer.

        public void FindCubic()
        {
            Console.Write("Enter the Number: ");
            int inputNumber = Int32.Parse(Console.ReadLine());
            double totalSum = 0;

            for (int i = 1; i <= inputNumber; i++)
            {
                double number = Math.Pow(i, 3);
                Console.WriteLine("Number is: " + i + " and cube of " + i + " is: " + number);
                totalSum += number;
            }

            Console.WriteLine("Total sum of all cube is: " + totalSum);
            Console.ReadLine();
        }
    }
}
