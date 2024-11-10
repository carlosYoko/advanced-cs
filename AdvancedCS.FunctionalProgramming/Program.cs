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


// Pipe generics
var cleanText2 = Functions.PipeGenerics(text, removeSpace, firstCapital, removeNumbers);
Console.WriteLine(cleanText2);

var numbersXPipeGenerics = Functions.PipeGenerics(numbers,
                                        (lst) => lst.MyMap((e) => e * 2),
                                        (lst) => lst.MyMap((e) => e - 1));
numbersXPipeGenerics.ForEach(Console.WriteLine);


// Pipe generics with several function types
var numberXPipeGenerics = numbers.PipeSeveralTypes(lst => lst.MyMap(e => e * 2))
                                    .PipeSeveralTypes(lst => lst.MyMap(e => e - 1))
                                    .PipeSeveralTypes(lst => lst.MyReduce((acc, cur) => acc + cur, 0));
Console.WriteLine(numberXPipeGenerics);


// Currying
Func<string, Func<string, string>> MyConcat()
{
    return a => b => a + " " + b;
}

var myConcat = MyConcat();
var myConcatWithHi = myConcat("Hello");
var myCocncatWithWorld = myConcatWithHi("World");
Console.WriteLine(myCocncatWithWorld);

Func<decimal, Func<decimal, Func<decimal, decimal>>> CalculateTotal = basePrice => tax => discount => (basePrice + (basePrice * tax) - discount);
var basePrice = 100;
var tax = 0.21m;
var discount = 5;

var calculateWithBasePrice = CalculateTotal(basePrice);
var calculateWithTax = calculateWithBasePrice(tax);
var amount = calculateWithTax(discount);
Console.WriteLine(amount);


// Memoization
var myPow = Memoization.MyPow(2);
Console.WriteLine(myPow(2));
Console.WriteLine(myPow(2));
Console.WriteLine(myPow(2));