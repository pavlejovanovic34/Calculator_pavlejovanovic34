using System.Text.RegularExpressions;
using CalculatorLibrary.Models;

namespace CalculatorLibrary
{
    internal class Helpers
    {
        public static List<Calculator> resultsHistory = new List<Calculator>();

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

        internal static double GetNumber()
        {
            if (resultsHistory.Count > 0)
            {
                Console.WriteLine("Do you want to calculate with previous result?(Y:N)");
                string answer = ValidateAnswerInput(Console.ReadLine());

                if (answer == "y")
                {
                    return resultsHistory[^1].Result;
                }

                else if(answer == "n") 
                {
                    Console.Clear();
                    return InputNumber();
                }

                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input.");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();

                    Console.Clear();
                    return GetNumber();
                }
            }

            else
            {
                Console.Clear();
                return InputNumber();
            }
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

        // exponent validation
        private static bool IsInteger(string number)
        {
            Regex regex = new Regex(@"^-?\d+$");

            return regex.IsMatch(number);
        }

        internal  static int ValidateExponentInput(string number)
        {
            while (!IsInteger(number))
            {
                Console.Clear();
                Console.WriteLine("Your must enter an integer value. Try again.");
                Console.Write("Your answer: ");
                number = Console.ReadLine();
            }

            return int.Parse(number);
        }

        // answer validation
        private static bool IsValidAnswer(string answer)
        {
            Regex regex = new Regex(@"^[yn]$");
            return regex.IsMatch(answer);
        }

        internal static string ValidateAnswerInput(string answer)
        {
             while (!IsStringWithoutBlancoSpaces(answer))
            {
                Console.Clear();
                Console.WriteLine("Your must enter a valid option. Try again.");
                Console.Write("Your answer: ");
                answer = Console.ReadLine();
            }

            return answer;
        }

        // list of results
        internal static void AddToHistory(double result, CalculationType type)
        {
            resultsHistory.Add(new Calculator(result, type));
        }

        internal static void PrintResultsHistory()
        {
            Console.Clear();

            Console.WriteLine($"Results of previous calculations:\n");

           if( resultsHistory.Count > 0 )
            {
                for (int i = 0; i < resultsHistory.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. Type of operation: {resultsHistory[i].CalculationType}, Result = {resultsHistory[i].Result}");
                }
            }

           else
            {
                Console.Clear();
                Console.WriteLine("You haven't made any calculation yet!");
            }

            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
        }

        // Divide By Zero Attempt
        internal static bool DivideByZeroAttempt(double number) => number == 0 ? true: false;
        
        // Converting angle to radians
        internal static double AngleToRadian(double angle) => Math.PI * angle / 180;
        
        internal static void Clear() 
        {
            Console.Clear();
            resultsHistory.Clear();
            Menu.MainMenu();
        }
    }
}
