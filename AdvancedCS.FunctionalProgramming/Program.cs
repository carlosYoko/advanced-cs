using AdvancedCS.FunctionalProgramming;

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