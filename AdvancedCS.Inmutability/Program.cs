var calculator = new Calculator(15);
Console.WriteLine(Calculator.PI); ;

public class Calculator
{
    public const double PI = 3.1416;
    public readonly int Value;

    public Calculator(int value)
    {
        Value = value;
    }
}