namespace CalculatorLibrary;

public class Menu
{
    public void MainMenu()
    {
        Console.WriteLine("CALCULATOR");
        Console.WriteLine("--------------------------------------------------\n");

        double numberOne = Helpers.InputNumber();
        
        /* OPTION MENU */
        double numberTwo = Helpers.InputNumber();

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
        string option = Helpers.ValidateOptionInput(Console.ReadLine());

        switch(option.ToLower())
        {
            case "add":
                Console.WriteLine("Addition");
                break;

            case "sub":
                Console.WriteLine("Subtraction");
                break;

            case "multi":
                Console.WriteLine("Multiplication");
                break;

            case "div":
                Console.WriteLine("Division");
                break;

            case "10x":
                Console.WriteLine("10x");
                break;

            case "pow":
                Console.WriteLine("Taking to power");
                break;

            case "sqrt":
                Console.WriteLine("Square root");
                break;

            case "sin":
                Console.WriteLine("Sinus");
                break;

            case "cos":
                Console.WriteLine("Cosinus");
                break;

            case "tan":
                Console.WriteLine("Tangens");
                break;

            case "ctan":
                Console.WriteLine("Cotangens");
                break;

            case "h":
                Console.WriteLine("History of calculations");
                break;

            case "cls":
                Console.WriteLine("Clear the history");
                break;

            case "q":
                Console.WriteLine("Quit the program");
                break;

            default:
                Console.WriteLine("invalid input");
                break;
        }

        /* OPTION MENU */
    }
    /*
            private double OptionMenu(double numberOne) 
            {
                
            }
    */
}