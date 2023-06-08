using CalculatorLibrary.Models;
using static CalculatorLibrary.Helpers;

namespace CalculatorLibrary;

internal class CalculatorOperations
{
    internal static void Addition()
    {
        Console.Clear();

        double numberOne = GetNumber();
        double numberTwo = InputNumber();
        double result = numberOne + numberTwo;

        Console.Clear();
        Console.WriteLine($"Result = {result}");
        AddToHistory(result, CalculationType.Addition);

        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
    }

    internal static void Subtraction()
    {
        Console.Clear();

        double numberOne = GetNumber();
        double numberTwo = InputNumber();
        double result = numberOne - numberTwo;

        Console.Clear();
        Console.WriteLine($"Result = {result}");
        AddToHistory(result, CalculationType.Subtraction);

        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
    }

    internal static void Multiplication()
    {
        Console.Clear();

        double numberOne = GetNumber();
        double numberTwo = InputNumber();
        double result = numberOne * numberTwo;

        Console.Clear();
        Console.WriteLine($"Result = {result}");
        AddToHistory(result, CalculationType.Multiplication);

        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
    }

    internal static void Division()
    {
        Console.Clear();

        double numberOne = GetNumber();
        double numberTwo = InputNumber();

        if(DivideByZeroAttempt(numberTwo))
        {
            Console.Clear();
            Console.WriteLine("Can't divide with zero. Press any key to continue");
            Console.ReadKey();
        }

        else
        {
            double result = numberOne / numberTwo;

            Console.Clear();
            Console.WriteLine($"Result = {result}");
            AddToHistory(result, CalculationType.Division);

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }    
    }
    internal static void TimesTen()
    {
        Console.Clear();

        double number = GetNumber();
        double result = number * 10;

        Console.Clear();
        Console.WriteLine($"Result = {result}");
        AddToHistory(result, CalculationType.TimesTen);

        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
    }

    internal static void Power()
    {
        Console.Clear();
        double result = 0;
        double number = GetNumber();

        Console.Write("Enter an exponent: ");
        int exponent = Helpers.ValidateExponentInput(Console.ReadLine());

        result = Math.Pow(number, exponent);

        Console.Clear();
        Console.WriteLine($"Result = {result}");
        AddToHistory(result, CalculationType.Power);

        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
    }

    internal static void SquareRoot()
    {
        Console.Clear();
        Console.WriteLine("If you enter negative number the result will be calculated based on entered number absolute value!");

        double number = GetNumber();
        double result = 0;

        number = Math.Abs(number);
        result = Math.Sqrt(number);

        Console.Clear();
        Console.WriteLine($"Result = {result}");
        AddToHistory(result, CalculationType.SquareRoot);

        
        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
    }

    internal static void Sinus()
    {
        Console.Clear();

        double number = GetNumber();
        double angle = AngleToRadian(number);

        double result = Math.Sin(angle);
        
        Console.Clear();
        Console.WriteLine($"Result = {result}");
        AddToHistory(result, CalculationType.Sine);

        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
    }

    internal static void Cosinus()
    {
        Console.Clear();

        double number = GetNumber();
        double angle = AngleToRadian(number);

        double result = Math.Cos(angle);

        Console.Clear();
        Console.WriteLine($"Result = {result}");
        AddToHistory(result, CalculationType.Cosine);

        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
    }

    internal static void Tangens()
    {
        Console.Clear();

        double number = GetNumber();
        double angle = AngleToRadian(number);
        
        double result = Math.Sin(angle) / Math.Cos(angle);

        Console.Clear();
        Console.WriteLine($"Result = {result}");
        AddToHistory(result, CalculationType.Tangens);

        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
    }

    internal static void Cotangens()
    {
        Console.Clear();

        double number = GetNumber();
        double angle = AngleToRadian(number);

        double result = Math.Cos(angle) / Math.Sin(angle);

        Console.Clear();
        Console.WriteLine($"Result = {result}");
        AddToHistory(result, CalculationType.Cotangens);

        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
    }
}
