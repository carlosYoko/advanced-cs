// Basic passing by reference
int num = 2;
Console.WriteLine(num); // 2
ChangeNum(ref num);
Console.WriteLine(num); // 10

void ChangeNum(ref int n)
{
    n = 10;
}