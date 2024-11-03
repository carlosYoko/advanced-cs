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

// Generics in extension methods
List<int> numbers = [15, 20, 30, 55];
int num = 20;
Console.WriteLine(num.Exists(numbers));

List<string> names = ["Carlos", "Pepe"];
string name = "Carlos";
Console.WriteLine(name.Exists(names));

// Generics with restriction in extension methods
Console.WriteLine(name.IsOn(names));



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

// Generics in extension methods
public static class ListExtensions
{
    public static bool Exists<T>(this T element, List<T> list)
    {
        foreach (T item in list)
        {
            if (item!.Equals(element))
            {
                return true;
            }
        }

        return false;
    }
}

// Generics with restriction in extension methods
public static class ListExtensionsWithRestriction
{
    public static bool IsOn<T>(this T element, List<T> list) where T : class
    {
        foreach (T item in list)
        {
            if (item!.Equals(element))
            {
                return true;
            }
        }

        return false;
    }
}

