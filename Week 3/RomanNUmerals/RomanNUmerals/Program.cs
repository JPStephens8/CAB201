using System;

namespace RomanNumerals
{
    class RomanNumeralConverter
    {
        const string roman_1 = "I";
        const string roman_2 = "II";
        const string roman_3 = "III";
        const string roman_4 = "IV";
        const string roman_5 = "V";
        const string roman_6 = "VI";
        const string roman_7 = "VII";
        const string roman_8 = "VIII";
        const string roman_9 = "IX";
        const string roman_10 = "X";

        public static void Main()
        {
            int input = 0;
            Console.Write("Please enter a number (1-10): ");
            string inputNumber = Console.ReadLine();
            
            if (int.TryParse(inputNumber, out input))
            {
                if (input >= 1 && input <= 10)
                {
                    switch (input)
                    {
                        case 1:
                            Console.WriteLine(input + " in Roman numbers is " + roman_1);
                            break;
                        case 2:
                            Console.WriteLine(input + " in Roman numbers is " + roman_2);
                            break;
                        case 3:
                            Console.WriteLine(input + " in Roman numbers is " + roman_3);
                            break;
                        case 4:
                            Console.WriteLine(input + " in Roman numbers is " + roman_4);
                            break;
                        case 5:
                            Console.WriteLine(input + " in Roman numbers is " + roman_5);
                            break;
                        case 6:
                            Console.WriteLine(input + " in Roman numbers is " + roman_6);
                            break;
                        case 7:
                            Console.WriteLine(input + " in Roman numbers is " + roman_7);
                            break;
                        case 8:
                            Console.WriteLine(input + " in Roman numbers is " + roman_8);
                            break;
                        case 9:
                            Console.WriteLine(input + " in Roman numbers is " + roman_9);
                            break;
                        case 10:
                            Console.WriteLine(input + " in Roman numbers is " + roman_10);
                            break;
                    }
                }

            }
            else
            {
                Console.WriteLine("Please enter a number between 1 and 10");
            }
            Console.WriteLine("Press enter to exit.");
            Console.ReadLine();
        }
    }
}