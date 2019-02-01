using System;
using System.Collections.Generic;
using System.Text;

namespace Day1
{
    class MultiplicationTable
    {
        public void FindMultiplication()
        {
            // Write a C# Sharp program that takes a number as input and print its multiplication table.

            Console.Write("Please Enter the Number: ");
            // The input will be of string type so we need to convert to int.
            string input = Console.ReadLine();
            int inputNumber = Int32.Parse(input);

            // We are using for loop to generate 1 ... 10
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(inputNumber + " X " + i + " = " + i * inputNumber);
            }
            //console.ReadLine will hold the screen ...
            Console.ReadLine();
        }
    }
}
