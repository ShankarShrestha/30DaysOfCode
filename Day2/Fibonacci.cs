using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DayCode.Day2
{
    class Fibonacci
    {
        public void DisplayFibonacci()
        {
            //  Write a program in C# Sharp to display the first n terms of Fibonacci series.

            // Get input from user
            Console.Write("Input number of terms to display: ");
            double inputNumber = Int32.Parse(Console.ReadLine());

            // initialization
            double first = 0;
            double second = 1;
            double third = 0;
            double i = 3;
            
            // Print first and second numbers.
            Console.Write(first + ", " + second +", ");

            // Start from 3rd number as we already print first and second. 
            // Loop until the i is less or equal to user input number.
            while(i <= inputNumber)
            {
                
                third = first + second;
                Console.Write(third + ", ");

                // Swap the variable.
                first = second;
                second = third;

                // increment of i by 1.
                i++;

            }

            Console.ReadLine();
        }

        public void DisplayFibonacciByRecursion()
        {
            // Get input from user
            Console.Write("Input number of terms to display: ");
            double inputNumber = Int32.Parse(Console.ReadLine());

            

            for(int i = 0; i <= inputNumber; i++)
            {
                Console.Write(getFibonacci(i) + " ");
            }


            Console.ReadLine();

        }

        // Helper method : This is using Recursion. function calling itself.

        private double getFibonacci(double num)
        {
            if (num == 0)
            {
                return 0;
            }
            else if (num == 1)
            {
                return 1;
            }
            else
            {
                return getFibonacci(num - 1) + getFibonacci(num - 2);
            }

        }
    }
}
