using AdvancedCS.FunctionalProgramming;

// Closures
var sum = Closure.SumClosure();
var someSum = Closure.SumClosure();
sum(2, 6);
sum(4, 3);
someSum(2, 4);

var delay = Closure.DelayExecuter(3000, () => Console.WriteLine("Funcion ejecutandose"));
delay();

// Map
List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

var stringNumbers = numbers.MyMap<int, string>(e => $"El numero es {e}");
foreach (var i in stringNumbers)
{
    Console.WriteLine(i);
}

// Filter
List<int> numbers2 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

var numbersEven = numbers2.MyFilter(e => e % 2 == 0);
foreach (var i in numbersEven)
{
    Console.WriteLine(i);
}
