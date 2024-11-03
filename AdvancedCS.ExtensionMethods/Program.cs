using AdvancedCS.ExtensionMethods;

// Basic extension method
int number = 10;
int number2 = number.X2();
int number3 = number2.X2();
Console.WriteLine(number);
Console.WriteLine(number2);
Console.WriteLine(number3);

// Extension methods in custom types
var sale = new Sale(345.21m);
Console.WriteLine(sale.GetInfo());

// Extension methods with params
var numberX3 = 4;
var resultNumberX3 = numberX3.Mul(3);
Console.WriteLine(resultNumberX3);



// Basic extension method
public static class IntOperations
{
    public static int X2(this int n)
    {
        return n * 2;
    }
}

// Extension methods in custom types
public static class SaleExtensions
{
    public static string GetInfo(this Sale sale)
    {
        return $"El total es: {sale.Amount}";
    }
}

// Extension methods with params
public static class IntOperationsWithParams
{
    public static int Mul(this int n, int multiplier)
    {
        return n * multiplier;
    }
}