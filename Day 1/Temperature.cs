using System;
using System.Collections.Generic;
using System.Text;

namespace Day1
{
    class Temperature
    {
        
        private string output;

        public void TemperatureConversion()
        {
            Console.WriteLine("Please key in the option");
            Console.WriteLine("Press 1 for Celcius to Fahrenheit");
            Console.WriteLine("Press 2 for Fahrenheit to Celcius");
            Console.WriteLine("Press 3 for Celcius to Kelvin");
            Console.WriteLine("Press 4 for Kelvin to Celcius");

            int option = Int32.Parse(Console.ReadLine());
            
            if (option == 1)
            {
                output = "Celcius to Fahrenheit: " + CelciusToFarenheit();
            }
            else if (option == 2) {
                output = "Fahrenheit to Celcius: " + FarenHeitToCelcius();
            }
            else if (option == 3)
            {
                output = "Celcius to Kelvin: " + CelciusToKelvin();
            }
            else if (option == 4)
            {
                output = "Kelvin to Celcius: " + KelvinToCelcius();
            }
            Console.WriteLine(output);
            Console.ReadLine();
        }

        

        private static double GetInput()
        {
            Console.Write("Enter the Value: ");
            return Double.Parse(Console.ReadLine());
        }

        private double CelciusToFarenheit()
        {
            //T(°F) = T(°C) × 9/5 + 32
            double degreeValue = GetInput();
            double farenheitValue = (degreeValue * 1.8) + 32;
            return farenheitValue;

        }
        private double FarenHeitToCelcius()
        {
            double farenheitValue = GetInput();
            double celciusValue = (farenheitValue - 32) / 1.8;
            return celciusValue;

        }
        private double CelciusToKelvin()
        {
            double celciusValue = GetInput();
            return celciusValue + 273;

        }
        private double KelvinToCelcius()
        {
            double kelvinValue = GetInput();
            return kelvinValue - 273;

        }
    }
}
