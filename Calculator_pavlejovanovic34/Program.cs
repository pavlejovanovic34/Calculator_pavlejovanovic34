using CalculatorLibrary;
using CalculatorLibrary.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Menu.MainMenu();
        Console.Clear();
        Console.WriteLine($"Number of calculations made: {Calculator.NumOfCalculations}");
    }
}