using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace SpeedConversion
{
    class MilesPerHourTable
    {
        static double kph;
        static double mph;
        public static void Main()
        {
            //print the kph and mph as columns
            Console.WriteLine("{0,-10} {1,10}", "KPH", "MPH");
            kph = 80;
            mph = (kph / 1.609344);

            for (kph = 80; kph < 350; kph += 15)
            {
                mph = (kph / 1.609344);
                Console.WriteLine("{0, -10} {1, 10}", kph, mph.ToString("#.00"));
            }
            
            Console.WriteLine("\n\nHit Enter to exit.");
            Console.ReadLine();
        }
    }
}