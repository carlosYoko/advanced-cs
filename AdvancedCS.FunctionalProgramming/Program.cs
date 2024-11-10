using AdvancedCS.FunctionalProgramming;
using System.Text.RegularExpressions;

// Closures
var sum = Closure.SumClosure();
var someSum = Closure.SumClosure();
sum(2, 6);
sum(4, 3);
someSum(2, 4);

var delay = Closure.DelayExecuter(3000, () => Console.WriteLine("Funcion ejecutandose"));
delay();

// #####################
// # Extension methods #
// #####################
List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

// Map
var stringNumbers = numbers.MyMap<int, string>(e => $"El numero es {e}");
foreach (var i in stringNumbers)
{
    Console.WriteLine(i);
}

// Filter
var numbersEven = numbers.MyFilter(e => e % 2 == 0);
foreach (var i in numbersEven)
{
    Console.WriteLine(i);
}

// Reduce
var total = numbers.MyReduce((acc, cur) => acc + cur, 0);
Console.WriteLine(total);

// Composition
Func<double, double, double> add = (a, b) => a + b;
Func<double, double> mulX2 = (a) => a * 2;
Func<double, double, double> mul = (a, b) => a * b;

Func<double, double, double> addAndMulX2 = (a, b) => mulX2(add(a, b));
Func<double, double, double, double> addAndMul = (a, b, c) => mul(add(a, b), c);

var result = addAndMulX2(10, 5);
var result2 = addAndMul(10, 5, 10);

Console.WriteLine(result);
Console.WriteLine(result2);

Func<int, string> myToString = (e) => $"Numero {e}";
Func<int, bool> max5 = (e) => e > 5;
Func<List<int>, List<string>> numbersMax5AndMyToString = (lst) => ListExtensions.MyMap(ListExtensions.MyFilter(lst, max5), myToString);

var result3 = numbersMax5AndMyToString(numbers);
result3.ForEach(Console.WriteLine);

// Pipe
Func<string, string> removeSpace = (s) => s.Replace(" ", "");
Func<string, string> firstCapital = (s) => char.ToUpper(s[0]) + s.Substring(1);
Func<string, string> removeNumbers = (s) => Regex.Replace(s, @"\d", "");

string text = "car234234 lo232323 234234s";
var cleanText = Functions.PipeStrings(text, removeSpace, firstCapital, removeNumbers);
Console.WriteLine(cleanText);