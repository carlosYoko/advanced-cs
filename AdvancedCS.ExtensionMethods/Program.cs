using AdvancedCS.ExtensionMethods;

int number = 10;
int number2 = number.X2();
int number3 = number2.X2();
Console.WriteLine(number);
Console.WriteLine(number2);
Console.WriteLine(number3);

var sale = new Sale(345.21m);
Console.WriteLine(sale.GetInfo());


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