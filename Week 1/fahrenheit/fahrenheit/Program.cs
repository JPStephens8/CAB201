using System;

namespace SimpleTempConversion
{
    public class FahrenheitToCelsius
    {
        public static void Main()
        {
            // Declare a variable to hold the temperature obtained from the user
            double FahrenheitTemp;

            // Declare a variable to hold the converted temperature
            double CelciusTemp;

            // Display "What is the temperature (in degrees Fahrenheit): "
            Console.Write("what is the temperature (in degrees Fahrenheit): ");

            // Read the current Fahrenheit temperature from the user
            FahrenheitTemp = double.Parse(Console.ReadLine());

            // Convert the Fahrenheit temperature into degrees Celsius
            CelciusTemp = (FahrenheitTemp - 32) * 5 / 9;

            // Display "The temperature is (temperature here) degrees Celsius"
            Console.WriteLine("The temperature is " + CelciusTemp + " degrees Celcius");

            // Prompt the user to press enter to close 
            Console.WriteLine("Press enter to exit.");
            Console.ReadLine();
        }
    }
}