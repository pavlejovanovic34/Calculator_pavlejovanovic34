namespace CalculatorLibrary.Models;

public class Calculator
{

    public static int NumOfCalculations { get; set; } = 0;

    public double Result { get; set; }

    public CalculationType CalculationType { get; set; }
    public Calculator(double result, CalculationType type) 
    {
        Result = result;
        CalculationType = type;
        NumOfCalculations++;
    }
}

public enum CalculationType
{
    Addition,
    Subtraction,
    Multiplication,
    Division,
    TimesTen,
    Power,
    SquareRoot,
    Sine,
    Cosine,
    Tangens,
    Cotangens,
}