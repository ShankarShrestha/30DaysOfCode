using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DayCode.Day1
{
    class LongWord
    {
        public void FindLongWord()
        {
            Console.WriteLine("Please Enter the Sentence: ");
            string inputSentence = Console.ReadLine();

            // Convert the input sentence in array of word.
            string[] inputArray = inputSentence.Split(' ');

            string longWord = inputArray[0];
            for (int i = 1; i < inputArray.Length; i++)
            {
                if (longWord.Length < inputArray[i].Length)
                {
                    longWord = inputArray[i];
                }
            }
            Console.WriteLine("The Longest word is: " + longWord);
            Console.ReadLine();
        }
    }
}
