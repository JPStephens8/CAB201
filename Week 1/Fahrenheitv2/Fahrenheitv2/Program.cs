using System;

namespace SimpleTempConversion
{
    public class FahrenheitToCelsiusV2
    {
        public static void Main()
        {
            // Declare a variable of type 'double' to hold the temperature obtained from the user
            double FahrenheitTemp;

            // Declare a variable of type 'double' to hold the converted temperature
            double CelsiusTemp;

            // Declare a bool to record if the user has entered in a valid number yet
            bool recordvalid;
            string inputTemp;

            do
            {
                // Display "What is the temperature (in degrees Fahrenheit): "
                Console.Write("What is the temperature (in degrees Fahrenheit): ");

                // Use TryParse() to read the Fahrenheit temperature. Set the bool variable
                // declared earlier to the result of TryParse()
                inputTemp = Console.ReadLine();
                recordvalid = double.TryParse(inputTemp, out FahrenheitTemp);

                // Check the bool variable to see if TryParse() failed to parse
                if (recordvalid == false)
                {
                    // Display "Invalid input" on a line by itself.
                    Console.WriteLine("Invalid Input");
                }

                // The code should loop while the input is not valid
            } while (recordvalid == false);

            // Convert the Fahrenheit temperature into degrees Celsius
            CelsiusTemp = (FahrenheitTemp - 32) * 5 / 9;

            // Display "The temperature is (temperature here) degrees Celsius"
            // Remember to replace (temperature here) with the Celsius temperature
            Console.WriteLine("The temperature is " + CelsiusTemp + " degrees Celsius");


            // Prompt the user to press enter to close the window
            Console.WriteLine("Press enter to exit.");
            Console.ReadLine();
        }
    }
}
