// Inmutability 
var calculator = new Calculator(15);
Console.WriteLine(Calculator.PI); ;

// Inmutability with props readonly
var brand = new Brand("Honda");
var brandName = brand.Name;


// Inmutability
public class Calculator
{
    public const double PI = 3.1416;
    public readonly int Value;

    public Calculator(int value)
    {
        Value = value;
    }
}

// Inmutability with props readonly
public class Brand
{
    public string Name { get; }
    public Brand(string name)
    {
        Name = name;
    }
}

// Inmutable list