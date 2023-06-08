namespace CalculatorLibrary.Models;

internal class Calculator
{
    internal static int NumOfCalculations { get; set; } = 0;

    internal double Result { get; set; }

    internal Calculator(double result) 
    {
        Result = result;
        NumOfCalculations++;
    }
}
