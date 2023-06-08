using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CalculatorLibrary
{
    internal class Helpers
    {
        // number validation
        private static bool IsDouble(string number)
        {
            Regex regex = new Regex(@"^[+-]?\d+(\.\d+)?$");
            return regex.IsMatch(number);
        }

        internal static double ValidateNumberInput(string number)
        {
            while (!Helpers.IsDouble(number))
            {
                Console.Clear();
                Console.WriteLine("Your input must be a number. Try again.");
                Console.Write("Your answer: ");
                number = Console.ReadLine();
            }

            return double.Parse(number);
        }

        internal static double InputNumber()
        {
            Console.Write("Enter a number: ");
            double number = Helpers.ValidateNumberInput(Console.ReadLine());

            return number;
        }

        // option validation
        private static bool IsStringWithoutBlancoSpaces(string option)
        {
            Regex regex = new Regex(@"^\S+$");
            return regex.IsMatch(option);
        }

        internal static string ValidateOptionInput(string option)
        {
            while (!IsStringWithoutBlancoSpaces(option))
            {
                Console.Clear();
                Console.WriteLine("Your must choose a valid option. Try again.");
                Console.Write("Your answer: ");
                option = Console.ReadLine();
            }

            return option;
        }
    }
}
