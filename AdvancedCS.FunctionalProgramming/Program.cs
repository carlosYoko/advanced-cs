using AdvancedCS.FunctionalProgramming;

// Closures
var sum = Closure.SumClosure();
var someSum = Closure.SumClosure();
sum(2, 6);
sum(4, 3);
someSum(2, 4);

var delay = Closure.DelayExecuter(3000, () => Console.WriteLine("Funcion ejecutandose"));
delay();