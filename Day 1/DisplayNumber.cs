using System;
using System.Collections.Generic;
using System.Text;

namespace Day1
{
    class DisplayNumber
    {
        // Write a C# program to that takes a number as input and display it 
        // four times in a row (separated by blank spaces), and then four 
        // times in the next row, with no separation. You should do it two times:

        public void GetNumber()
        {
            Console.Write("Please Enter the Number: ");
            //int inputNumber = Int32.Parse(Console.ReadLine());
            string inputNumber = Console.ReadLine();

            string displayNumberSpace = "";
            string displayNumber = "";

            for (int i = 1; i < 5; i++)
            {
                displayNumberSpace += inputNumber + " ";
                displayNumber += inputNumber;

            }

            Console.WriteLine(displayNumberSpace);
            Console.WriteLine(displayNumber);
            Console.ReadLine();
        }
    }
}
