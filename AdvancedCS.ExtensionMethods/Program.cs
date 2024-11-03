int number = 10;
int number2 = number.X2();
int number3 = number2.X2();

Console.WriteLine(number);
Console.WriteLine(number2);
Console.WriteLine(number3);

public static class IntOperations
{
    public static int X2(this int n)
    {
        return n * 2;
    }
}