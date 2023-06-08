using static CalculatorLibrary.Helpers;
using static CalculatorLibrary.CalculatorOperations;

namespace CalculatorLibrary;

public class Menu
{
    public static void MainMenu() 
    {
        bool continueCalculations = true;
  
        do
        {
            string option = OptionMenu();

            continueCalculations = OptionChoice(option, continueCalculations);
            
        }
        while (continueCalculations != false);
    }
    
    private static string OptionMenu()
    {
        Console.Clear();
        Console.WriteLine(@$"Choose an option: 
        Add - Addition
        Sub - Subtraction
        Multi - Multiplication
        Div - Divison
        10x - 10x
        Pow - Taking to power 
        Sqrt - Square root
        Sin - Sinus
        Cos - Cosinus
        Tan - Tangens
        Ctan - Cotanges
        H - History of calculations
        Cls - Clear the history of calculations
        Q - Quit the program
        ");

        Console.Write("Your option: ");
        return ValidateOptionInput(Console.ReadLine());
    }

    private static bool OptionChoice(string option, bool continueCalculations)
    {
        switch (option.ToLower())
        {
            case "add":
                Addition();
                return true;

            case "sub":
                Subtraction();
                return true;

            case "multi":
                Multiplication();
                return true;

            case "div":
                Division();
                return true;
 
            case "10x":
                TimesTen();
                return true;
 
            case "pow":
                Power();
                return true;

            case "sqrt":
                SquareRoot();
                Console.ReadKey();
                return true;

            case "sin":
                Sinus();
                return true;

            case "cos":
                Cosinus();
                return true;

            case "tan":
                Tangens();
                return true;
 
            case "ctan":
                Cotangens();
                return true;

            case "h":
                PrintResultsHistory();
                return true;
 
            case "cls":
                Clear();
                return true;

            case "q":
                return false;

            default:
                Console.Clear();
                Console.WriteLine("Invalid input. Try again\n Press any key to continue");
                Console.ReadKey();
                
                return true;
        }
    }
}