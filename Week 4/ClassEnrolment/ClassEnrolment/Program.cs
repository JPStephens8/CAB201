using System;

namespace ClassEnrolment
{

    class ClassEnrolment
    {

        public static void Main()
        {
            string[] className = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
            int[] currentEnrolment = new int[] { 15, 10, 3, 12, 3 };
            int[] maximumEnrolment = new int[] { 28, 21, 24, 22, 26 };

            Console.WriteLine("Number of places still available for each class.\n");

            // Write a "for" loop here, using the className.Length property.
            // Do not change any of the existing lines of code.

            for (int i = 0; i < className.Length; i++)
            {
                Console.WriteLine(className[i] + " has a current enrolment of " + currentEnrolment[i] + " and a maximum of " + maximumEnrolment[i] + ".");
            }

            ExitProgram();
        }

        public static void ExitProgram()
        {
            Console.Write("Press enter to continue ...");
            Console.ReadLine();
        }
    }
}